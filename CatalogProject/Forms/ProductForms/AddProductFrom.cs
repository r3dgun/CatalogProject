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
        private Product product;
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
        }

        private void btnMainSaveImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog { Filter = "تصاویر|*.jpg;*.png;*.bmp;*.gif" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    txtProductImagePath.Text = ofd.FileName;
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
                }
            }
        }

        private void btnSaveProduct_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCompanyName.Text) || (string.IsNullOrEmpty(txtSecondImagePath.Text)) || (string.IsNullOrEmpty(txtSecondImagePath.Text)) || (string.IsNullOrEmpty(txtDescribtion.Text)))
            {
                MessageBox.Show("مشخصات را درست وارد کنید");
                return;
            }
            var imageName = Helper.SaveFileToDirectoryAndGetImageName(txtProductImagePath.Text,
                Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "ProductImage"));
            var imageSecondName = Helper.SaveFileToDirectoryAndGetImageName(txtSecondImagePath.Text,
                Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "ProductImage"));
            Product product = new Product()
            {
                CategoryId = _categoryId,
                Price = decimal.Parse(txtPrice.Text),
                MainText = txtMainText.Text,
                SecondImage = imageSecondName,
                Name = txtCompanyName.Text,
                Description = txtDescribtion.Text,
                Image = imageName,
            };
            var productId = _productService.InsertProduct(product);
            List<Option> options = new List<Option>();
            for (int i = 1; i < 6; i++)
            {
                var textBoxes = bunifuGroupBox1.Controls.OfType<TextBox>().ToList().Where(t => t.Name.Contains(i.ToString()));
                var name = textBoxes.First(t => t.Name.Contains("value")).Text;
                var value = textBoxes.First(t => t.Name.Contains("Name")).Text;
                if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(value))
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

            var optionIds = _optionService.InsertOptions(options);
        }
    }
}
