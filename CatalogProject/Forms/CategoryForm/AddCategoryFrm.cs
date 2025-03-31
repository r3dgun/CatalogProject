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
    public partial class AddCategoryFrm : Form
    {
        private CategoryService _categoryService;
        private CompanyService _companyService;
        private bool _imageChange = false;
        private Category _category = null;
        private int _CompanyId;
        public AddCategoryFrm(int companyId, int categoryId = 0)
        {
            InitializeComponent();
            _CompanyId = companyId;
            _categoryService = new CategoryService();
            _companyService = new CompanyService();
            if (categoryId != 0)
            {
                _category = _categoryService.GetCategoryById(categoryId);
                FillCategoryForUpdate(_category);
            }
        }
        public void FillCategoryForUpdate(Category category)
        {
            var imageAddress = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "CategoryImage",
                category.Image);
            FillPicBox(imageAddress);
            txtCategoryImageName.Text = imageAddress;
            txtDescribtion.Text = category.Description;
            txtCompanyName.Text = category.Name;
        }
        private void btnInsertCategory_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCompanyName.Text) || (string.IsNullOrEmpty(txtCategoryImageName.Text)))
            {
                MessageBox.Show("مشخصات را درست وارد کنید");
                return;
            }

            if (_category == null)
            {
                var imageName = Helper.SaveFileToDirectoryAndGetImageName(txtCategoryImageName.Text,
                    Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "CategoryImage"));
                Category category = new Category()
                {
                    CompanyId = _CompanyId,
                    Name = txtCompanyName.Text,
                    Description = txtDescribtion.Text,
                    Image = imageName
                };
                var categoryId = _categoryService.InsertCategory(category);
            }
            else
            {
                string imageName = null;
                if (_imageChange)
                {
                    imageName = Helper.SaveFileToDirectoryAndGetImageName(txtCategoryImageName.Text,
                        Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "CategoryImage"));
                }
                _category.Name = txtCompanyName.Text;
                _category.Description = txtDescribtion.Text;
                _category.Image = _imageChange ? imageName : _category.Image;


                var categoryId = _categoryService.InsertCategory(_category);
            }
            this.Close();

        }

        public void FillPicBox(string imagePass)
        {
            PicBoxImage.Image = Helper.LoadImageFromPath(imagePass);
        }

        private void btnSaveImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog { Filter = "تصاویر|*.jpg;*.png;*.bmp;*.gif" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    txtCategoryImageName.Text = ofd.FileName;
                    FillPicBox(ofd.FileName);
                    _imageChange = true;
                }
            }
        }

    }
}
