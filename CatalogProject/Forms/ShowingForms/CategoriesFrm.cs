using CatalogProject.Controlls;
using CatalogProject.Servise.Category;
using CatalogProject.Servise.helper;
using Microsoft.Extensions.DependencyInjection;
using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatalogProject.Forms.ShowingForms
{
    public partial class CategoriesFrm : Form
    {
        private readonly ICategoryService _categoryService;
        private int _companyId;
        private List<Category> _categories;
        private int _cardCount;
        private int _pageNumber;
        private int _pageCount;
        private List<CategoryCard> _categoryCards;
        private bool _isAnimationRunning = false;
        private CancellationTokenSource _animationCts;

        public CategoriesFrm(ICategoryService categoryService)
        {
            InitializeComponent();
            OptimizeFormRendering();
            _categoryService = categoryService;
            _animationCts = new CancellationTokenSource();
        }

        public void InitializeData(int companyId)
        {
            _companyId = companyId;
            _categories = _categoryService.GetCategoriesWithCompanyId(companyId);
        }

        private void OptimizeFormRendering()
        {
            // Set form-level double buffering
            this.DoubleBuffered = true;

            // Apply double buffering to all controls
            EnableDoubleBufferingForAllControls(this);

            // Optimize layout operations
            this.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
        }

        private void EnableDoubleBufferingForAllControls(Control container)
        {
            foreach (Control control in container.Controls)
            {
                // Enable double buffering for current control
                PropertyInfo doubleBufferProp = control.GetType().GetProperty("DoubleBuffered",
                    BindingFlags.Instance | BindingFlags.NonPublic);

                if (doubleBufferProp != null)
                {
                    doubleBufferProp.SetValue(control, true, null);
                }

                // Apply to child controls recursively
                if (control.Controls.Count > 0)
                {
                    EnableDoubleBufferingForAllControls(control);
                }
            }
        }

        private void CategoriesFrm_Load(object sender, EventArgs e)
        {
            // Load form asynchronously
            Task.Run(() => LoadFormDataAsync());
        }

        private async Task LoadFormDataAsync()
        {
            // Ensure UI operations run on UI thread
            await this.InvokeAsync(() => {
                _categoryCards = tableLayoutPanel1.Controls.OfType<CategoryCard>().OrderBy(cc => cc.Name).ToList();
                _pageNumber = 1;
                SetPageCount();

                // Initialize cards without animations first
                foreach (var card in _categoryCards)
                {
                    card.HideGradiantPanel();
                }

                InitialCompanyCartDetail(_pageNumber);

                // Resume layout operations
                tableLayoutPanel1.ResumeLayout(false);
                this.ResumeLayout(false);
            });

            // Show cards with animation after layout is complete
            await this.InvokeAsync(() => ShowCardsWithAnimation(_cardCount));
        }

        private void SetPageCount()
        {
            int totalCategory = _categories.Count();
            _pageCount = (int)Math.Ceiling((double)totalCategory / 4);

            UpdateNavigationButtons();
        }

        private void UpdateNavigationButtons()
        {
            BtnNextPage.Enabled = _pageNumber < _pageCount;
            BtnPreviosPage.Enabled = _pageNumber > 1;
        }

        private void InitialCompanyCartDetail(int pageNumber)
        {
            var skip = 4 * (pageNumber - 1);
            var categoriesTemp = _categories.Skip(skip).Take(4).ToList();
            _cardCount = categoriesTemp.Count;
            SetCartDetail(categoriesTemp);
        }

        private void SetCartDetail(List<Category> categories)
        {
            // Set details for each card
            for (int i = 0; i < 4; i++)
            {
                if (i < categories.Count)
                {
                    _categoryCards[i].SetCartDetail(categories[i]);
                }
                else
                {
                    _categoryCards[i].HideCartDetail();
                }
            }
        }

        private async Task ShowCardsWithAnimation(int cardCount)
        {
            // Configure faster animations
            bunifuTransition1.Interval = 20; // Increase frame rate
            bunifuTransition1.MaxAnimationTime = 2500; // Reduce animation time

            var randomAnimation = Helper.GetRandomAnimations();

            // Show cards with animation
            for (int i = 0; i < cardCount; i++)
            {
                bunifuTransition1.ShowSync(_categoryCards[i].GetBunifuGradientPanel(), false, randomAnimation[i]);
                await Task.Delay(50); // Small delay between cards for visual effect
            }
        }

        private async Task HideCardsWithAnimation(int cardCount)
        {
            // Configure faster animations
            bunifuTransition1.Interval = 20; // Increase frame rate
            bunifuTransition1.MaxAnimationTime = 2500; // Reduce animation time

            var randomAnimation = Helper.GetRandomAnimations();

            // Hide cards with animation
            for (int i = 0; i < cardCount; i++)
            {
                bunifuTransition1.HideSync(_categoryCards[i].GetBunifuGradientPanel(), false, randomAnimation[i]);
                await Task.Delay(50);
            }
        }

        private async void BtnNextPage_Click(object sender, EventArgs e)
        {
            await ChangePage(1);
        }

        private async void BtnPreviosPage_Click(object sender, EventArgs e)
        {
            await ChangePage(-1);
        }
        private async void CategoryCart_Click(object sender, EventArgs e)
        {
            if (sender is CategoryCard cart)
            {
                // Show the loader
                //bunifuLoader1.Visible = true;

                // Get the form instance
                var productsFrm = Program.ServiceProvider.GetRequiredService<ProductsFrm>();

                // Initialize data in background

                // You may need to adjust this if InitializeData must run on UI thread
                productsFrm.InitializeData(_categories[int.Parse(cart.Tag.ToString())].Id);


                // Hide the loader after initialization is complete
                //bunifuLoader1.Visible = false;

                // Show the form
                this.Hide();
                productsFrm.ShowDialog();
                this.Show();
            }
        }
        private async Task ChangePage(int direction)
        {
            if (_isAnimationRunning)
                return;

            _isAnimationRunning = true;

            // Cancel any ongoing animations
            _animationCts.Cancel();
            _animationCts = new CancellationTokenSource();

            try
            {
                // Disable navigation during animation
                BtnNextPage.Enabled = false;
                BtnPreviosPage.Enabled = false;

                // Update page number
                _pageNumber += direction;

                // Hide current cards
                await HideCardsWithAnimation(_cardCount);

                // Load new data
                InitialCompanyCartDetail(_pageNumber);

                // Show new cards
                await ShowCardsWithAnimation(_cardCount);

                // Update navigation buttons
                UpdateNavigationButtons();
            }
            catch (OperationCanceledException)
            {
                // Animation was canceled, ignore
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error changing page: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                _isAnimationRunning = false;
            }
        }
    }

    // Extension method for invoking on UI thread
    public static class ControlExtensions
    {
        public static async Task InvokeAsync(this Control control, Action action)
        {
            if (control.InvokeRequired)
            {
                await Task.Factory.FromAsync(
                    control.BeginInvoke(action),
                    control.EndInvoke);
            }
            else
            {
                action();
            }
        }
    }
}
