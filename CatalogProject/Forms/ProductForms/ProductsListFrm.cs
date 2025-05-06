using CatalogProject.Servise.Category;
using CatalogProject.Servise.helper;
using Models;
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
using CatalogProject.Servise.Option;
using CatalogProject.Servise.Product;

namespace CatalogProject.ProductFroms
{
    public partial class ProductsListFrm : Form
    {
        private int _categoryId;
        private ProductService _productService;
        private OptionService _optionService;

        public ProductsListFrm(int categoryId)
        {
            InitializeComponent();
            _categoryId = categoryId;
            _productService = new ProductService();
            _optionService = new OptionService();
            ConfigureGridView();
            LoadProducts();

        }

        private void btnAddProduct_ButtonClick(object sender, EventArgs e)
        {

            this.Hide();
            AddProductFrom addProductFrom = new AddProductFrom(_categoryId);
            addProductFrom.ShowDialog();
            LoadProducts();
            this.Show();

        }

        private void BtnUpdateProduct_ButtonClick(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("لطفاً یک ردیف را انتخاب کنید!", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this.Hide();
            int selectedId = (int)dgvProducts.SelectedRows[0].Cells["Id"].Value;
            AddProductFrom addProductFrom = new AddProductFrom(_categoryId, selectedId);
            addProductFrom.ShowDialog();
            LoadProducts();
            this.Show();


        }

        private void BtnDeleteProduct_ButtonClick(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("لطفاً یک ردیف را انتخاب کنید!", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (DialogResult.Yes ==
                MessageBox.Show("ایا از کار خود مطمعن هستید؟با اینکار تمام زیر مجموعه ها پاک میشوند.", "هشدار",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                int selectedId = (int)dgvProducts.SelectedRows[0].Cells["Id"].Value;
                _optionService.DeleteProductOptions(selectedId);
                _productService.DeleteProduct(selectedId);
                LoadProducts();
            }
        }
        private void LoadProducts()
        {
            dgvProducts.DataSource = null;
            dgvProducts.Rows.Clear();
            dgvProducts.Refresh();
            // دریافت داده‌ها از دیتابیس
            var products = _productService.GetProductWithCategoryId(_categoryId);
            var dgvProductModels = products.Select(c => new DgvProduct()
            {
                
                CreatedAt = c.CreatedAt.ConvertMiladiToShamsi(),
                Description = c.Description,
                Id = c.Id,
                Image = Helper.LoadImageFromPath(c.Image,Helper.PathName.ProductImage),
                SecondImage = Helper.LoadImageFromPath(c.SecondImage,Helper.PathName.ProductImage),
                Name = c.Name,
                MainText = c.MainText,
                OptionIds = _optionService.GetProductsOptionsName(c.Id),
                Price = c.Price
            }).ToList();
            // اتصال لیست به DataGridView
            dgvProducts.DataSource = dgvProductModels;
        }
        private void ConfigureGridView()
        {
            // Create custom columns
            var columns = new DataGridViewColumn[]
                    {
                            new DataGridViewTextBoxColumn
                            {
                                Name = "Id",
                                DataPropertyName = "Id",
                                HeaderText = "ID",
                                Visible = false,
                            },
                            new DataGridViewTextBoxColumn
                            {
                                Name = "Name",
                                DataPropertyName = "Name",
                                HeaderText = "نام محصول",
                                Width = 150
                            },
                            new DataGridViewTextBoxColumn
                            {
                                Name = "MainText",
                                DataPropertyName = "MainText",
                                HeaderText = "متن اصلی",
                                Width = 200
                            },
                            new DataGridViewTextBoxColumn
                            {
                                Name = "Description",
                                DataPropertyName = "Description",
                                HeaderText = "توضیحات",
                                Width = 200
                            },
                            new DataGridViewTextBoxColumn
                            {
                                Name = "Price",
                                DataPropertyName = "Price",
                                HeaderText = "قیمت",
                                Width = 100,
                                DefaultCellStyle = new DataGridViewCellStyle
                                {
                                    Format = "N0"  // Number format for currency
                                }
                            },
                            new DataGridViewImageColumn
                            {
                                Name = "Image",
                                DataPropertyName = "Image",
                                HeaderText = "تصویر اصلی",
                                Width = 150,
                                ImageLayout = DataGridViewImageCellLayout.Zoom
                            },
                            new DataGridViewImageColumn
                            {
                                Name = "SecondImage",
                                DataPropertyName = "SecondImage",
                                HeaderText = "تصویر دوم",
                                Width = 150,
                                ImageLayout = DataGridViewImageCellLayout.Zoom
                            },
                            new DataGridViewTextBoxColumn
                            {
                                Name = "CreatedAt",
                                DataPropertyName = "CreatedAt",
                                HeaderText = "تاریخ ایجاد",
                                Width = 150,
                                DefaultCellStyle = new DataGridViewCellStyle
                                {
                                    Format = "yyyy/MM/dd HH:mm"
                                }
                            },
                            new DataGridViewTextBoxColumn
                            {
                                Name = "OptionIds",
                                DataPropertyName = "OptionIds",
                                HeaderText = "گزینه ها",
                                Width = 150
                            }
                         };
            dgvProducts.RowTemplate.Height = 100;
            dgvProducts.Columns.AddRange(columns);
            dgvProducts.AutoGenerateColumns = false;
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.ReadOnly = true;
        }
    }
}
