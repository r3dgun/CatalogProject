using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
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
    public partial class CompanyCard : UserControl
    {
        private readonly Company _company;
        public int CompanyID;

        public CompanyCard()
        {
            InitializeComponent();
            OptimizeFormRendering();

            // Make sure child controls also trigger the click event

            Pic_Box.Click += (s, e) => this.OnClick(e);


        }
        private void OptimizeFormRendering()
        {
            // Set form-level double buffering
            this.DoubleBuffered = true;

            // Apply double buffering to all controls
            EnableDoubleBufferingForAllControls(this);

        }

        private void EnableDoubleBufferingForAllControls(Control container)
        {
            foreach (Control control in container.Controls)
            {
                // Enable double buffering for current control
                PropertyInfo doubleBufferProp = control.GetType().GetProperty("DoubleBuffered",
                    BindingFlags.Instance | BindingFlags.NonPublic);

                if (doubleBufferProp != null)
                {
                    doubleBufferProp.SetValue(control, true, null);
                }

                // Apply to child controls recursively
                if (control.Controls.Count > 0)
                {
                    EnableDoubleBufferingForAllControls(control);
                }
            }
        }
    
 
        public void SetCartDetail(Company company)
        {
            CompanyID = company.Id;
            lbl_CompanyName.Text = "نام شرکت :" + @"  " + company.Name;
            lbl_CompanyPhone.Text = "تلفن :" + @"  " + company.Phone;
            lbl_CompanyAddress.Text = "آدرس :" + @"  " + company.Address;
            lbl_CompanyEmail.Text = "ایمیل :" + @"  " + company.Email;
            lbl_CompanyDesc.Text = "معرفی :" + @"  " + company.Description;
            Pic_Box.Image = Helper.LoadImageFromPath(company.Logo, Helper.PathName.CompanyImage);
        }
      
    }

}
