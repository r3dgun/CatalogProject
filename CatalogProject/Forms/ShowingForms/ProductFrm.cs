using Bunifu.Framework.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.UI.WinForms.BunifuAnimatorNS;
using CatalogProject.Servise.helper;
using CatalogProject.Servise.Option;
using CatalogProject.Servise.Product;
using Models;
using System.Reflection;
using Bunifu.UI.WinForms;

namespace CatalogProject.Forms.ShowingForms
{
    public partial class ProductFrm : Form
    {
        private IOptionService _optionService;
        private IProductService _productService;
        private Product _product;
        private List<Option> _options;
        private bool _havePrice = true;
        private int _optionCount;


        public ProductFrm(IProductService productService, IOptionService optionService)
        {
            InitializeComponent();
            OptimizeFormRendering();
            _optionService = optionService;
            _productService = productService;

        }
        private void OptimizeFormRendering()
        {
            // Set form-level double buffering
            this.DoubleBuffered = true;

            // Apply double buffering to all controls
            EnableDoubleBufferingForAllControls(this);

            // Optimize layout operations

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
        public async Task InitializeData(int productId)
        {
            _options = _optionService.GetProductsOptions(productId);
            _product = _productService.GetProductById(productId);
            picBox_product.Image = Helper.LoadImageFromPath(_product.Image, Helper.PathName.ProductImage);
            picBox_product.Hide();
            productDetail.Hide();
            productOptions.Hide();
            await productOptions.initilizeOptionsData(_options);
            await initializePicData(_product);
            await productDetail.InitializeDetailData(_product);

        }

        private void ProductFrm_Load(object sender, EventArgs e)
        {
            Task.Run(() => MakeFromReady());
        }
        public async Task MakeFromReady()
        {
            this.InvokeAsync(() =>
                {
                    //todo: create user control product detail and use it here fo
                    //todo make form ready for show it contain product detail and product options and picture 
                    bunifuTransition1.Interval = 20; // Increase frame rate
                    bunifuTransition1.MaxAnimationTime = 5000; // Reduce animation time
                    ShowPic();
                    ShowDetail();
                    ShowOptions();
                }
            );
        }
     
        public async Task initializePicData(Product product)
        {
            if (!string.IsNullOrEmpty(product.Image))
            {
                picBox_product.Image = Helper.LoadImageFromPath(product.Image, Helper.PathName.ProductImage);
                bunifuPictureBox1.Image = Helper.LoadImageFromPath(product.Image, Helper.PathName.ProductImage);

            }
            else
            {
                bunifuPictureBox1.Visible = false;
            }
            if (!string.IsNullOrEmpty(product.SecondImage))
            {
                bunifuPictureBox2.Image = Helper.LoadImageFromPath(product.SecondImage, Helper.PathName.ProductImage);

            }
            else
            {
                bunifuPictureBox2.Visible = false;
            }
            if (!string.IsNullOrEmpty(product.ThirdImage))
            {
                bunifuPictureBox3.Image = Helper.LoadImageFromPath(product.ThirdImage, Helper.PathName.ProductImage);
            }
            else
            {
                bunifuPictureBox3.Visible = false;
            }

        }
        private async Task ShowPic()
        {
            bunifuCard_Image.BackColor=Color.Aquamarine;
            bunifuTransition1.ShowSync(picBox_product, false, Animation.Rotate);
            await Task.Delay(50); // Small delay between cards for visual effect
            bunifuCard_Image.BackColor = Color.Transparent;

        }
        private async Task ShowDetail()
        {
            bunifuCards_Detail.BackColor = Color.Chocolate;
            bunifuTransition1.ShowSync(productDetail, false, Animation.VertSlide);
            await Task.Delay(50); // Small delay between cards for visual effect
            bunifuCards_Detail.BackColor = Color.Transparent;

        }
        private async Task ShowOptions()
        {
            bunifuCards_Options.BackColor = Color.DarkRed;

            bunifuTransition1.ShowSync(productOptions, false, Animation.HorizSlide);
            await Task.Delay(50); // Small delay between cards for visual effect
            bunifuCards_Options.BackColor = Color.Transparent;

        }
    }
}
