using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using Bunifu.UI.WinForms;
using CatalogProject.Servise.helper;
using Models;
using BunifuGradientPanel = Bunifu.UI.WinForms.BunifuGradientPanel;

namespace CatalogProject.Controlls
{
    public partial class CompanyCart : UserControl
    {
        private readonly Company _company;


        public CompanyCart()
        {
            InitializeComponent();

            this.SetStyle(ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.OptimizedDoubleBuffer |
                          ControlStyles.UserPaint, true);
            this.UpdateStyles();
            tableLayoutPanel.SuspendLayout();
            tableLayoutPanel.ResumeLayout();
     
        }

        public void HideGradiantPanel()
        {
            bunifuGradientPanel.Hide();
        }
        public BunifuGradientPanel GetBunifuGradientPanel()
        {
            return this.bunifuGradientPanel;
        }
        public void SetCartDetail(Company company)
        {
            BunifuCard.Visible = true;
            lbl_CompanyName.Text = "نام شرکت :" + @"  " + company.Name;
            lbl_CompanyAddress.Text = "تلفن :" + @"  " + company.Address;
            lbl_CompanyDesc.Text = "آدرس :" + @"  " + company.Description;
            lbl_CompanyPhone.Text = "ایمیل :" + @"  " + company.Phone;
            lbl_CompanyEmail.Text = "معرفی :" + @"  " + company.Email;
            Pic_Box.Image = Helper.LoadImageFromPath(company.Logo, Helper.PathName.CompanyImage);
        }
        public void HideCartDetail()
        {
            BunifuCard.Visible = false;

        }

        private void tableLayoutPanel_Click(object sender, EventArgs e)
        {

        }
    }

}
