using CatalogProject.Servise.helper;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.UI.WinForms;

namespace CatalogProject.Controlls
{
    public partial class ProductCard : UserControl
    {
        private readonly Product _product;

        public ProductCard()
        {
            InitializeComponent();

            this.SetStyle(ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.OptimizedDoubleBuffer |
                          ControlStyles.UserPaint, true);
            this.UpdateStyles();
            tableLayoutPanel.SuspendLayout();
            tableLayoutPanel.ResumeLayout();

            // Make sure child controls also trigger the click event
            if (this.GradientPanel != null)
            {
                Pic_Box.Click += (s, e) => this.OnClick(e);

            }

        }

        public void HideGradiantPanel()
        {
            GradientPanel.Hide();
        }
        public BunifuGradientPanel GetBunifuGradientPanel()
        {
            return this.GradientPanel;
        }
        public void SetCartDetail(Company company)
        {
            bunifuCard.Visible = true;
            lbl_CompanyName.Text = "نام شرکت :" + @"  " + company.Name;
            lbl_CompanyPhone.Text = "تلفن :" + @"  " + company.Phone;
            lbl_CompanyAddress.Text = "آدرس :" + @"  " + company.Address;
            lbl_CompanyEmail.Text = "ایمیل :" + @"  " + company.Email;
            lbl_CompanyDesc.Text = "معرفی :" + @"  " + company.Description;
            Pic_Box.Image = Helper.LoadImageFromPath(company.Logo, Helper.PathName.CompanyImage);
        }
        public void HideCartDetail()
        {
            bunifuCard.Visible = false;

        }
    }
}
