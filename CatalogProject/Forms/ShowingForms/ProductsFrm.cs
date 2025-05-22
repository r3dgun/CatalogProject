using CatalogProject.Controlls;
using CatalogProject.Servise.Category;
using CatalogProject.Servise.helper;
using Microsoft.Extensions.DependencyInjection;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using CatalogProject.Servise.Product;

namespace CatalogProject.Forms.ShowingForms
{
    public partial class ProductsFrm : Form
    {
        private readonly IProductService _productService;
        private int _categoryId;
        private List<Product> _products;
        private int _cardCount;
        private int _pageNumber;
        private int _pageCount;
        private List<ProductCard> _productCards = new List<ProductCard>();
        private List<BunifuCards> _cardsList;

        private bool _isAnimationRunning = false;
        private CancellationTokenSource _animationCts;

        public ProductsFrm(IProductService productService)
        {
            InitializeComponent();
            OptimizeFormRendering();
            _productService = productService;
            _animationCts = new CancellationTokenSource();
        }

        public void InitializeData(int categoryId)
        {
            _categoryId = categoryId;
            _products = _productService.GetProductWithCategoryId(_categoryId);
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

        private void ProductsFrm_Load(object sender, EventArgs e)
        {
            // Load form asynchronously
            Task.Run(() => LoadFormDataAsync());
        }

        private async Task LoadFormDataAsync()
        {
            // Ensure UI operations run on UI thread
            await this.InvokeAsync(() =>
            {
                _cardsList = tableLayoutPanel1.Controls.OfType<BunifuCards>().OrderBy(cc => cc.Name).ToList();

                _pageNumber = 1;
                SetPageCount();
                _productCards.Add(productCard1);
                _productCards.Add(productCard2);
                _productCards.Add(productCard3);
                _productCards.Add(productCard4);
                _productCards.Add(productCard5);
                _productCards.Add(productCard6);
                _productCards.Add(productCard7);
                _productCards.Add(productCard8);


                // Initialize cards without animations first
                foreach (var card in _productCards)
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
            int totalCategory = _products.Count();
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
            var ProductsTemp = _products.Skip(skip).Take(8).ToList();
            _cardCount = ProductsTemp.Count;
            SetCartDetail(ProductsTemp);
        }

        private void SetCartDetail(List<Product> products)
        {
            // Set details for each card
            for (int i = 0; i < 8; i++)
            {
                if (i < products.Count)
                {
                    _productCards[i].Visible = true;
                    _productCards[i].SetCartDetail(products[i]);
                }
                else
                {
                    _productCards[i].Visible=false;
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
                bunifuTransition1.ShowSync(_productCards[i].GetBunifuGradientPanel(), false, randomAnimation[i]);
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
                bunifuTransition1.HideSync(_productCards[i].GetBunifuGradientPanel(), false, randomAnimation[i]);
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
        private async void ProductCart_Click(object sender, EventArgs e)
        {
            if (sender is ProductCard cart)
            {
                // Show the loader

                // Get the form instance
                var productFrm = Program.ServiceProvider.GetRequiredService<ProductFrm>();

                // You may need to adjust this if InitializeData must run on UI thread
                await productFrm.InitializeData(cart.ProductId);
                // Hide the loader after initialization is complete

                // Show the form
                this.Hide();
                productFrm.ShowDialog();
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

}
