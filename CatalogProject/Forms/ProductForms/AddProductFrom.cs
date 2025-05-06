using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CatalogProject.Forms.ShowingForms;
using CatalogProject.Servise.Category;
using CatalogProject.Servise.helper;
using CatalogProject.Servise.Option;
using CatalogProject.Servise.Product;
using Models;

namespace CatalogProject.ProductFroms
{
    public partial class AddProductFrom : Form
    {
        private Models.Product _product;
        private List<Option> _options;
        private bool _mainImageChange = false;
        private bool _secondImageChange = false;

        private ProductService _productService;
        private CategoryService _categoryService;
        private OptionService _optionService;
        private int _categoryId;


        public AddProductFrom(int categoryId, int productId = 0)
        {
            _categoryId = categoryId;
            InitializeComponent();
            _categoryService = new CategoryService();
            _optionService = new OptionService();
            _productService = new ProductService();
            if (productId != 0)
            {
                _product = _productService.GetProductById(productId);
                _options = _optionService.GetProductsOptions(productId);
                btnSaveProduct.Text = "بروزرسانی محصول";
                InitializeForm(_options, _product);
            }

        }


        private void InitializeForm(List<Option> options, Product product)
        {
            txtProductName.Text = product.Name;
            txtProductImagePath.Text = product.Image;
            txtSecondImagePath.Text = product.SecondImage;
            txtDescribtion.Text = product.Description;
            txtPrice.Text = product.Price.ToString();
            txtMainText.Text = product.MainText;
            PicBoxMain.Image = Helper.LoadImageFromPath(product.Image, Helper.PathName.ProductImage);
            PicBoxSecond.Image = Helper.LoadImageFromPath(product.SecondImage, Helper.PathName.ProductImage);
            txtDescribtion.Text = product.Description;
            for (int i = 1; i <= options.Count; i++)
            {
                var textBoxes = bunifuGroupBox1.Controls.OfType<TextBox>().Where(t => t.Name.Contains(i.ToString())).ToList();
                textBoxes.First(t => t.Name.Contains("Value")).Text = options[i - 1].Value;
                textBoxes.First(t => t.Name.Contains("Name")).Text = options[i - 1].Name;
            }

        }

        private void btnMainSaveImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog { Filter = "تصاویر|*.jpg;*.png;*.bmp;*.gif" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    txtProductImagePath.Text = ofd.FileName;
                    PicBoxMain.ImageLocation = ofd.FileName;

                    _mainImageChange = true;
                }
            }
        }

        private void btnSecondSaveImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog { Filter = "تصاویر|*.jpg;*.png;*.bmp;*.gif" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    txtSecondImagePath.Text = ofd.FileName;
                    PicBoxSecond.ImageLocation = ofd.FileName;

                    _secondImageChange = true;
                }
            }
        }

        private void btnSaveProduct_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtProductName.Text) || (string.IsNullOrEmpty(txtSecondImagePath.Text)) || (string.IsNullOrEmpty(txtSecondImagePath.Text)) || (string.IsNullOrEmpty(txtDescribtion.Text)))
            {
                MessageBox.Show("مشخصات را درست وارد کنید");
                return;
            }

            if (_product == null)
            {
                var imageName = Helper.SaveFileToDirectoryAndGetImageName(txtProductImagePath.Text,
                    Helper.PathName.ProductImage);
                var imageSecondName = Helper.SaveFileToDirectoryAndGetImageName(txtSecondImagePath.Text,
                    Helper.PathName.ProductImage);
                Product product = new Product()
                {
                    CategoryId = _categoryId,
                    Price = decimal.Parse(txtPrice.Text),
                    MainText = txtMainText.Text,
                    SecondImage = imageSecondName,
                    Name = txtProductName.Text,
                    Description = txtDescribtion.Text,
                    Image = imageName,
                };
                var productId = _productService.InsertProduct(product);
                var options = GetOptions(productId);

                var optionIds = _optionService.InsertOptions(options);
            }
            else
            {
                if (_mainImageChange)
                {
                    var imageName = Helper.SaveFileToDirectoryAndGetImageName(txtProductImagePath.Text,
                        Helper.PathName.ProductImage);
                    _product.Image = imageName;

                }
                if (_secondImageChange)
                {
                    var imageSecondName = Helper.SaveFileToDirectoryAndGetImageName(txtSecondImagePath.Text,
                        Helper.PathName.ProductImage);
                    _product.SecondImage = imageSecondName;

                }

                _product.Price = decimal.Parse(txtPrice.Text);
                _product.MainText = txtMainText.Text;
                _product.Name = txtProductName.Text;
                _product.Description = txtDescribtion.Text;
                _productService.UpdateProduct(_product);
                _optionService.DeleteProductOptions(_product.Id);
                var options = GetOptions(_product.Id);
                _optionService.InsertOptions(options);
            }
            this.Close();
        }

        private List<Option> GetOptions(int productId)
        {
            List<Option> options = new List<Option>();
            for (int i = 1; i < 6; i++)
            {
                var textBoxes = bunifuGroupBox1.Controls.OfType<TextBox>().Where(t => t.Name.Contains(i.ToString())).ToList();
                var value = textBoxes.First(t => t.Name.Contains("Value")).Text;
                var name = textBoxes.First(t => t.Name.Contains("Name")).Text;
                if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(value))
                {
                    Option option = new Option()
                    {
                        Name = name,
                        Value = value,
                        ProductId = productId
                    };
                    options.Add(option);
                }
            }

            return options;
        }
    }
}
