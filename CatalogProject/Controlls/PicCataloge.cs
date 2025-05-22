using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.UI.WinForms;
using CatalogProject.Servise.helper;
using Models;

namespace CatalogProject.Controlls
{
    public partial class PicCataloge : UserControl
    {
        private string _currentimageName;

        public PicCataloge()
        {
            InitializeComponent();
            OptimizeFormRendering();
            bunifuPictureBox1.Click += PictureBox_Click;
            bunifuPictureBox2.Click += PictureBox_Click;
            bunifuPictureBox3.Click += PictureBox_Click;
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
        private void PictureBox_Click(object sender, EventArgs e)
        {
            var pic = sender as PictureBox;
            if (pic != null && !string.IsNullOrEmpty(pic.ImageLocation))
            {
                _currentimageName = System.IO.Path.GetFileName(pic.ImageLocation);
            }
        }

        private string GetCurrentImageName()
        {
            return _currentimageName;
        }
        public async Task initializeData(Product product)
        {
            if (!string.IsNullOrEmpty(product.Image))
            {
                bunifuPictureBox1.Image = Helper.LoadImageFromPath(product.Image, Helper.PathName.ProductImage);

            }
            else
            {
                bunifuPictureBox1.Visible = false;
            }
            if (!string.IsNullOrEmpty(product.SecondImage))
            {
                bunifuPictureBox2.Image = Helper.LoadImageFromPath(product.SecondImage, Helper.PathName.ProductImage);

            }
            else
            {
                bunifuPictureBox2.Visible = false;
            }
            if (!string.IsNullOrEmpty(product.ThirdImage))
            {
                bunifuPictureBox3.Image = Helper.LoadImageFromPath(product.ThirdImage, Helper.PathName.ProductImage);

            }
            else
            {
                bunifuPictureBox3.Visible = false;
            }

        }

    }
}
