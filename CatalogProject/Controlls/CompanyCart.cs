using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CatalogProject.Servise.helper;
using Models;

namespace CatalogProject.Controlls
{
    public partial class CompanyCart : UserControl
    {
        private readonly Company _company;
        public void InitilizeCompanyCart()
        {
            LbCompanyAddress.Text += _company.Address;
            LbCompanyDescription.Text += _company.Description;
            LbCompanyEmail.Text += _company.Email;
            LbCompanyName.Text += _company.Name;
            LbCompanyPhone.Text += _company.Phone;
            PicBoxLogo.Image = Helper.LoadImageFromPath(_company.Logo, Helper.PathName.CompanyImage);

        }
        public CompanyCart(Company company)
        {
            _company = company;

            InitializeComponent();
            InitilizeCompanyCart();
        }
    }
   
}
