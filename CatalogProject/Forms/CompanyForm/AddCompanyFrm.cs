using CatalogProject.Servise.Category;
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
using CatalogProject.Servise;
using CatalogProject.Servise.Company;
using CatalogProject.Servise.helper;

namespace CatalogProject.Forms.CompanyForm
{
    public partial class AddCompanyFrm : Form
    {
        private CompanyService _companyService;
        private Company _company = null;
        private bool _imageChanged = false;
        public AddCompanyFrm(int companyId = 0)
        {
            _companyService = new CompanyService();
            InitializeComponent();
            if (companyId != 0)
            {
                _company = _companyService.GetCompaniesById(companyId);
                FillCompanyForUpdate(_company);
            }
        }

        private void btnAddCompany_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtCompanyName.Text) || (string.IsNullOrEmpty(txtImageName.Text)))
            {
                MessageBox.Show("مشخصات را درست وارد کنید");
                return;
            }
            if (_company == null)
            {
                var imageName = Helper.SaveFileToDirectoryAndGetImageName(txtImageName.Text,

                    Helper.PathName.CompanyImage);
                Company company = new Company()
                {
                    Address = txtAddress.Text,
                    Name = txtCompanyName.Text,
                    Description = txtDescribtion.Text,
                    Logo = imageName,
                    Email = txtEmail.Text,
                    Phone = txtPhoneNumber.Text
                };
                if (_companyService.InsertCompany(company))
                {
                    this.Close();
                }
            }
            else
            {

                string imageName = null;
                if (_imageChanged)
                {
                    imageName = Helper.SaveFileToDirectoryAndGetImageName(txtImageName.Text,
                       Helper.PathName.CompanyImage);
                }
                _company.Address = txtAddress.Text;
                _company.Name = txtCompanyName.Text;
                _company.Description = txtDescribtion.Text;
                _company.Logo = _imageChanged ? _company.Logo : imageName;
                _company.Email = txtEmail.Text;
                _company.Phone = txtPhoneNumber.Text;

                if (_companyService.UpdateCompany(_company))
                {
                    this.Close();
                }
            }
        }


        public void FillCompanyForUpdate(Company company)
        {
            var image = Helper.LoadImageFromPath(company.Logo, Helper.PathName.CompanyImage);
            PicBoxLogo.Image = image;
            txtImageName.Text = image.ToString();
            txtDescribtion.Text = company.Description;
            txtCompanyName.Text = company.Name;
            txtAddress.Text = company.Address;
            txtEmail.Text = company.Email;
            txtPhoneNumber.Text = company.Phone;
        }
        private void btnloadImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog { Filter = "تصاویر|*.jpg;*.png;*.bmp;*.gif" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    txtImageName.Text = ofd.FileName;
                    _imageChanged = true;
                    PicBoxLogo.Image = Helper.LoadImageFromPath(ofd.FileName);

                }
            }
        }
    }
}
