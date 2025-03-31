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
using CatalogProject.Servise.Category;
using CatalogProject.Servise.Company;
using CatalogProject.Servise.helper;
using Models;

namespace CatalogProject.Forms.CategoryForm
{
    public partial class CompanyListFrm : Form
    {
        private CompanyService _companyService;
        private CategoryService _categoryService;

        public CompanyListFrm()
        {
            InitializeComponent();
            _companyService = new CompanyService();
            _categoryService = new CategoryService();
            ConfigureGridView();

            LoadCompanies();
        }

        private void LoadCompanies()
        {
            dgvComanies.DataSource = null;
            dgvComanies.Rows.Clear();
            dgvComanies.Refresh();
            var imagePath = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "CompanyImage");
            // دریافت داده‌ها از دیتابیس
            var companies = _companyService.GetAllCompanies();
            var dgvCompanyModels = companies.Select(c=>new DgvCompany
            {
                Address = c.Address,
                CreatedAt = c.CreatedAt,
                Description = c.Description,
                Id = c.Id,
                Phone = c.Phone,
                Email = c.Email,
                Logo = Helper.LoadImageFromPath(imagePath,c.Logo),
                Name = c.Name,
                CategoryIds = _categoryService.GetCategoriesNameWithCompanyId(c.Id)
            }).ToList();
            // اتصال لیست به DataGridView
            dgvComanies.DataSource = dgvCompanyModels;
        }

        private void btnAddCompany_ButtonClick(object sender, EventArgs e)
        {
            this.Hide();
            AddCompanyFrm frmAddCompany = new AddCompanyFrm();
            frmAddCompany.ShowDialog();
            this.Show();

            LoadCompanies();
        }

        private void BtnCategories_ButtonClick(object sender, EventArgs e)
        {
            if (dgvComanies.SelectedRows.Count == 0)
            {
                MessageBox.Show("لطفاً یک ردیف را انتخاب کنید!", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedId = (int)dgvComanies.SelectedRows[0].Cells["Id"].Value;
            CategoryListFrm frmCategoryList = new CategoryListFrm(selectedId);
            this.Hide();
            frmCategoryList.ShowDialog();
            this.Show();
            LoadCompanies();
        }

        private void BtnDeleteCompany_ButtonClick(object sender, EventArgs e)
        {
            if (dgvComanies.SelectedRows.Count == 0)
            {
                MessageBox.Show("لطفاً یک ردیف را انتخاب کنید!", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (DialogResult.Yes ==
                MessageBox.Show("ایا از کار خود مطمعن هستید؟با اینکار تمام زیر مجموعه ها پاک میشوند.", "هشدار",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                //todo: pak kardan tamam zire majmoe ha
                int selectedId = (int)dgvComanies.SelectedRows[0].Cells["Id"].Value;
                _companyService.DeleteCompany(selectedId);
                _categoryService.DeleteCategory(selectedId);
                LoadCompanies();
            }

        }

        private void BtnUpdateCompany_ButtonClick(object sender, EventArgs e)
        {
            if (dgvComanies.SelectedRows.Count == 0)
            {
                MessageBox.Show("لطفاً یک ردیف را انتخاب کنید!", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedId = (int)dgvComanies.SelectedRows[0].Cells["Id"].Value;
            this.Hide();
            AddCompanyFrm frmAddCompany = new AddCompanyFrm(selectedId);
            frmAddCompany.ShowDialog();
            this.Show();
            LoadCompanies();
          
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
                HeaderText = "اسم شرکت",
                Width = 150
            },
            new DataGridViewTextBoxColumn
            {
                Name = "Description",
                DataPropertyName = "Description",
                HeaderText = "توضیحات",
                Width = 200
            },
            new DataGridViewImageColumn
            {
                Name = "Logo",
                HeaderText = "عکس",
                Width = 150,  // Make column wider
                ImageLayout = DataGridViewImageCellLayout.Zoom,
                DataPropertyName = "Logo"
            },
            new DataGridViewTextBoxColumn
            {
                Name = "Address",
                DataPropertyName = "Address",
                HeaderText = "آدرس",
                Width = 150
            },
            new DataGridViewTextBoxColumn
            {
                Name = "Phone",
                DataPropertyName = "Phone",
                HeaderText = "شماره تلفن",
                Width = 100
            },
            new DataGridViewTextBoxColumn
            {
                Name = "Email",
                DataPropertyName = "Email",
                HeaderText = "ایمیل",
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
                Name = "CategoryIds",
                DataPropertyName = "CategoryIds",
                HeaderText = "زیر مجموعه ها",
                Width = 150,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "dd/MM/yyyy HH:mm"
                }
            }
        };
            dgvComanies.RowTemplate.Height = 100;
            dgvComanies.Columns.AddRange(columns);
            dgvComanies.AutoGenerateColumns = false;
            dgvComanies.AllowUserToAddRows = false;
            dgvComanies.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvComanies.ReadOnly = true;
        }
    }

}
