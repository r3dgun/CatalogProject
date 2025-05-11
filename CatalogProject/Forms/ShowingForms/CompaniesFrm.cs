using Bunifu.UI.WinForms.BunifuAnimatorNS;
using CatalogProject.Servise.Company;
using CatalogProject.Servise.helper;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CatalogProject.Controlls;
using BunifuTransition = BunifuAnimatorNS.BunifuTransition;
using System.Reflection;

namespace CatalogProject.Forms.ShowingForms
{
    public partial class CompaniesFrm : Form
    {
        private readonly List<Company> _companies;
        private readonly ICompanyService _companyService;
        private int _cardCount;
        private int _pageNumber;
        private List<CompanyCart> companyCards ;


        public CompaniesFrm(ICompanyService companyService)
        {
            InitializeComponent();
            MakeFormFaster();
            companyCards = tableLayoutPanel1.Controls.OfType<CompanyCart>().OrderBy(cc=>cc.Name).ToList();
            _companyService = companyService;
            _companies = _companyService.GetAllCompanies();
            SetPageCount();
            _pageNumber = 1;
        }

        private void MakeFormFaster()
        {
            // فعال کردن Double Buffering برای فرم
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.OptimizedDoubleBuffer |
                          ControlStyles.UserPaint |
                          ControlStyles.ResizeRedraw, true);
            this.UpdateStyles();

            // فعال کردن Double Buffering برای TableLayoutPanel
            typeof(TableLayoutPanel).InvokeMember("DoubleBuffered",
                System.Reflection.BindingFlags.SetProperty |
                System.Reflection.BindingFlags.Instance |
                System.Reflection.BindingFlags.NonPublic,
                null, tableLayoutPanel1, new object[] { true });

            // فعال کردن Double Buffering برای همه کنترل‌های داخل فرم
            EnableDoubleBufferingForAllControls(this);

            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel1.ResumeLayout(false);
            // تنظیمات بهینه برای BunifuTransition
            bunifuTransition1.Interval = 20; // افزایش سرعت فریم

        }
        private void EnableDoubleBufferingForAllControls(Control container)
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
                    EnableDoubleBufferingForAllControls(control);
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

            var randomAnimation = GetRandomAnimations();
            bunifuTransition1.MaxAnimationTime = 2500;
            for (int i = 0; i < cardCount; i++)
            {
                bunifuTransition1.HideSync(companyCards[i].GetBunifuGradientPanel(), false, randomAnimation[i]);
            }
            await Task.Delay(300);

        }
        private async void ShowCards(int cardCount)
        {
            var randomAnimation = GetRandomAnimations();
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

        private List<Animation> GetRandomAnimations()
        {
            List<Animation> allAnimations = new List<Animation>
            {
                Animation.Particles,
                Animation.HorizSlideAndRotate,
                Animation.HorizBlind,
                Animation.Leaf,
                Animation.Mosaic,
                Animation.Rotate,
                Animation.Transparent,
                Animation.VertBlind,
                Animation.VertSlide,
                Animation.HorizSlide,
                Animation.Scale,
                Animation.ScaleAndRotate,
                Animation.ScaleAndHorizSlide,
                // می‌توانید انیمیشن‌های دیگری را اضافه کنید
            };
            // لیست تمامی انیمیشن‌ها را دریافت می‌کنیم
            Random random = new Random();
            List<Animation> randomAnimations = new List<Animation>();

            // اگر تعداد انیمیشن‌ها بیشتر از 4 باشد
            while (randomAnimations.Count < 4)
            {
                Animation selectedAnimation = allAnimations[random.Next(allAnimations.Count)];

                // اگر انیمیشن انتخاب‌شده قبلاً انتخاب نشده باشد، آن را اضافه می‌کنیم
                if (!randomAnimations.Contains(selectedAnimation))
                {
                    randomAnimations.Add(selectedAnimation);
                }
            }

            return randomAnimations;
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PageChanger_Scroll(object sender, Utilities.BunifuSlider.BunifuVScrollBar.ScrollEventArgs e)
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

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
