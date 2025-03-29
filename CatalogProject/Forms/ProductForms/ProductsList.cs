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
using CatalogProject.Servise.Product;

namespace CatalogProject.ProductFroms
{
    public partial class ProductsList : Form
    {
        private int _categoryId;
        private ProductService _productService;

        public ProductsList(int categoryId)
        {
            InitializeComponent();
            _categoryId = categoryId;
            _productService = new ProductService();
            ConfigureGridView();
            LoadCategories();

        }

        private void btnAddProduct_ButtonClick(object sender, EventArgs e)
        {
            AddProductFrom addProductFrom = new AddProductFrom(_categoryId);
            addProductFrom.ShowDialog();
        }

        private void BtnUpdateProduct_ButtonClick(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("لطفاً یک ردیف را انتخاب کنید!", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            LoadCategories();

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
                _productService.DeleteProduct(selectedId);
                LoadCategories();
            }
        }
        private void LoadCategories()
        {
            dgvProducts.DataSource = null;
            dgvProducts.Rows.Clear();
            dgvProducts.Refresh();
            var imagePath = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "ProductImage");
            // دریافت داده‌ها از دیتابیس
            var products = _productService.GetProductWithCategoryId(_categoryId);
            var dgvProductModels = products.Select(c => new DgvProduct()
            {
                
                CreatedAt = c.CreatedAt,
                Description = c.Description,
                Id = c.Id,
                Image = Helper.LoadImageFromPath(imagePath, c.Image),
                SecondImage = Helper.LoadImageFromPath(imagePath, c.SecondImage),
                Name = c.Name,
                MainText = c.MainText,
                OptionIds = _productService.GetProductNameWithCategoryId(c.Id)
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
                                    Format = "dd/MM/yyyy HH:mm"
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
