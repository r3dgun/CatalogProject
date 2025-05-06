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
using CatalogProject.ProductFroms;
using CatalogProject.Servise.Category;
using CatalogProject.Servise.helper;
using CatalogProject.Servise.Product;
using Models;

namespace CatalogProject.Forms.CategoryForm
{
    public partial class CategoryListFrm : Form
    {
        private int _companyId;
        private CategoryService _categoryService;
        private ProductService _productService;
        public CategoryListFrm( int companyId)
        {
            InitializeComponent();
            _companyId = companyId;
            _categoryService = new CategoryService();
            _productService = new ProductService();
            ConfigureGridView();
            LoadCategories();
        }

        private void btnAddCategory_ButtonClick(object sender, EventArgs e)
        {
            this.Hide();
            AddCategoryFrm frmAddCategory = new AddCategoryFrm(_companyId);
            frmAddCategory.ShowDialog();
            this.Show();

            LoadCategories();

        }

        private void btnDeleteCategory_ButtonClick(object sender, EventArgs e)
        {
            if (DgvCategories.SelectedRows.Count == 0)
            {
                MessageBox.Show("لطفاً یک ردیف را انتخاب کنید!", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (DialogResult.Yes ==
                MessageBox.Show("ایا از کار خود مطمعن هستید؟با اینکار تمام زیر مجموعه ها پاک میشوند.", "هشدار",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                int selectedId = (int)DgvCategories.SelectedRows[0].Cells["Id"].Value;
                _categoryService.DeleteCategory(selectedId);
                _productService.DeleteProductWithCategoryId(selectedId);
                LoadCategories();
            }
        }

        private void btnProductList_ButtonClick(object sender, EventArgs e)
        {
            if (DgvCategories.SelectedRows.Count == 0)
            {
                MessageBox.Show("لطفاً یک ردیف را انتخاب کنید!", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int selectedCategoryId = (int)DgvCategories.SelectedRows[0].Cells["Id"].Value;
            ProductsList addProductFrom = new ProductsList(selectedCategoryId);
            this.Hide();
            addProductFrom.ShowDialog();
            this.Show();
            LoadCategories();

        }

        private void btnUpdateCategory_ButtonClick(object sender, EventArgs e)
        {
            if (DgvCategories.SelectedRows.Count == 0)
            {
                MessageBox.Show("لطفاً یک ردیف را انتخاب کنید!", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int selectedId = (int)DgvCategories.SelectedRows[0].Cells["Id"].Value;
            this.Hide();
            AddCategoryFrm frmAddCategory = new AddCategoryFrm(_companyId, selectedId);
            frmAddCategory.ShowDialog();
            this.Show();

            LoadCategories();

        }
        private void LoadCategories()
        {
            DgvCategories.DataSource = null;
            DgvCategories.Rows.Clear();
            DgvCategories.Refresh();
            // دریافت داده‌ها از دیتابیس
            var categories = _categoryService.GetCategoriesWithCompanyId(_companyId);
            var dgvCompanyModels = categories.Select(c => new DgvCategory()
            {
                CompanyId = c.CompanyId,
                CreatedAt = c.CreatedAt,
                Description = c.Description,
                Id = c.Id,
                Image = Helper.LoadImageFromPath( c.Image,Helper.PathName.CategoryImage),
                Name = c.Name,
                ProductIds = _productService.GetProductNameWithCategoryId(c.Id)
            }).ToList();
            // اتصال لیست به DataGridView
            DgvCategories.DataSource = dgvCompanyModels;
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
                HeaderText = "اسم دسته",
                Width = 150
            },
         
            new DataGridViewImageColumn
            {
                Name = "Image",
                HeaderText = "عکس",
                Width = 150,  // Make column wider
                ImageLayout = DataGridViewImageCellLayout.Zoom,
                DataPropertyName = "Image"
            },
            new DataGridViewTextBoxColumn
            {
                Name = "Description",
                DataPropertyName = "Description",
                HeaderText = "توضیحات",
                Width = 150
            },
          
            new DataGridViewTextBoxColumn
            {
                Name = "CreatedAt",
                DataPropertyName = "CreatedAt",
                HeaderText = "تاریخ ساخت",
                Width = 150,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "dd/MM/yyyy HH:mm"
                }
            },
            new DataGridViewTextBoxColumn
            {
                Name = "ProductIds",
                DataPropertyName = "ProductIds",
                HeaderText = "زیر مجموعه ها",
                Width = 150,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "dd/MM/yyyy HH:mm"
                }
            }
        };
            DgvCategories.RowTemplate.Height = 100;
            DgvCategories.Columns.AddRange(columns);
            DgvCategories.AutoGenerateColumns = false;
            DgvCategories.AllowUserToAddRows = false;
            DgvCategories.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvCategories.ReadOnly = true;
        }
    }
}
