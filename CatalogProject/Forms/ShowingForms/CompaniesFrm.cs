using CatalogProject.Controlls;
using CatalogProject.Servise.Company;
using CatalogProject.Servise.helper;
using Microsoft.Extensions.DependencyInjection;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatalogProject.Forms.ShowingForms
{
    public partial class CompaniesFrm : Form
    {
        private readonly List<Company> _companies;
        private readonly ICompanyService _companyService;
        private int _cardCount;
        private int _pageNumber;
        private List<CompanyCart> companyCards;


        public CompaniesFrm(ICompanyService companyService)
        {
            InitializeComponent();
            MakeFormFaster();
            companyCards = tableLayoutPanel1.Controls.OfType<CompanyCart>().OrderBy(cc => cc.Name).ToList();
            _companyService = companyService;
            _companies = _companyService.GetAllCompanies();
            SetPageCount();
            _pageNumber = 1;

        }


        private async void MakeFormFaster()
        {

            // فعال کردن Double Buffering برای همه کنترل‌های داخل فرم
            await EnableDoubleBufferingForAllControls(this);

            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel1.ResumeLayout(false);

        }
        private async Task EnableDoubleBufferingForAllControls(Control container)
        {
            foreach (Control control in container.Controls)
            {
                // فعال کردن Double Buffering برای کنترل فعلی
                PropertyInfo doubleBufferProp = control.GetType().GetProperty("DoubleBuffered",
                    System.Reflection.BindingFlags.Instance |
                    System.Reflection.BindingFlags.NonPublic);

                if (doubleBufferProp != null)
                {
                    doubleBufferProp.SetValue(control, true, null);
                }

                // اعمال برای کنترل‌های داخلی به صورت بازگشتی
                if (control.Controls.Count > 0)
                {
                    await EnableDoubleBufferingForAllControls(control);
                }
            }
        }
        private void SetPageCount()
        {
            int totalCompanies = _companies.Count();
            int pageCount = (int)Math.Ceiling((double)totalCompanies / 4);

            // Set minimum to 1 if there are any companies, otherwise 0
            if (pageCount != 1)
                PageChanger.Maximum = pageCount;
            else
                PageChanger.Enabled = false;
            InitialCompanyCartDetail(_pageNumber);
        }

        private void InitialCompanyCartDetail(int pageNumber)
        {
            var skip = 4 * (pageNumber - 1);
            var CompanyTemp = _companies.Skip(skip).Take(4).ToList();
            _cardCount = CompanyTemp.Count;
            SetCartDetail(CompanyTemp);
        }


        private void SetCartDetail(List<Company> companies)
        {
            // Define arrays of controls for each card

            // Set details for each card up to cartCount
            for (int i = 0; i < 4; i++)
            {
                if (i < companies.Count)
                {
                    companyCards[i].SetCartDetail(companies[i]);
                }
                else
                {
                    companyCards[i].HideCartDetail();
                }
            }
        }

        private void CompaniesFrm_Load(object sender, EventArgs e)
        {
            HideGradiantPanel(_cardCount);
            ShowCards(_cardCount);
        }
        private async void HideGradiantPanel(int cardCount)
        {
            for (int i = 0; i < cardCount; i++)
            {
                companyCards[i].HideGradiantPanel();
            }
        }
        private async void HideAsyncGradiantPanel(int cardCount)
        {
            //var bunifuCards = new[] { bunifuCards1, bunifuCards2, bunifuCards3, bunifuCards4 };
            bunifuTransition1.Interval = 20; // افزایش سرعت فریم

            var randomAnimation = Helper.GetRandomAnimations();
            bunifuTransition1.MaxAnimationTime = 2500;
            for (int i = 0; i < cardCount; i++)
            {
                bunifuTransition1.HideSync(companyCards[i].GetBunifuGradientPanel(), false, randomAnimation[i]);
            }
            await Task.Delay(300);

        }
        private async void ShowCards(int cardCount)
        {
            var randomAnimation = Helper.GetRandomAnimations();
            bunifuTransition1.MaxAnimationTime = 2500;
            for (int i = 0; i < cardCount; i++)
            {
                bunifuTransition1.ShowSync(companyCards[i].GetBunifuGradientPanel(), false, randomAnimation[i]);
            }
            await Task.Delay(100);

        }
        private void btn_Exit_Click(object sender, EventArgs e)
        {

        }




        bool _isRun = false;


        private void PageChanger_ValueChanged(object sender, Utilities.BunifuSlider.BunifuVScrollBar.ValueChangedEventArgs e)
        {
            if (PageChanger.Value != _pageNumber && !_isRun)
            {
                PageChanger.Enabled = false;
                _isRun = true;
                _pageNumber = PageChanger.Value;
                HideAsyncGradiantPanel(_cardCount);
                InitialCompanyCartDetail(_pageNumber);
                Thread.Sleep(1000);
                ShowCards(_cardCount);
                Thread.Sleep(1000);
                PageChanger.Enabled = true;
                _isRun = false;

            }
        }


        private async void companyCart_Click(object sender, EventArgs e)
        {
            if (sender is CompanyCart cart)
            {
                // Show the loader
                //bunifuLoader1.Visible = true;

                // Get the form instance
                var categoriesFrm = Program.ServiceProvider.GetRequiredService<CategoriesFrm>();

                // Initialize data in background

                // You may need to adjust this if InitializeData must run on UI thread
                categoriesFrm.InitializeData(_companies[int.Parse(cart.Tag.ToString())].Id);


                // Hide the loader after initialization is complete
                //bunifuLoader1.Visible = false;

                // Show the form
                this.Hide();
                categoriesFrm.ShowDialog();
                this.Show();
            }
        }
    }
}
