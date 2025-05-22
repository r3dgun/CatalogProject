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
using System.Reflection;

namespace CatalogProject.Controlls
{
    public partial class CategoryCard : UserControl
    {
        public int CategoryId { get; set; }
        public CategoryCard()
        {
            InitializeComponent();
            OptimizeFormRendering();
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
        public void HideGradiantPanel()
        {
            bunifuGradientPanel.Hide();
        }
        public BunifuGradientPanel GetBunifuGradientPanel()
        {
            return this.bunifuGradientPanel;
        }
        public void SetCartDetail(Category category)
        {
            CategoryId = category.Id;
            lbl_CategoryName.Text = "نام دسته :" + @"  " + category.Name;
            lbl_CategoryDisc.Text = "توضیحات :" + @"  " + category.Description;
            Pic_Box.Image = Helper.LoadImageFromPath(category.Image, Helper.PathName.CategoryImage);
        }
     
    }
}
