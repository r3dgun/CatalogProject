using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    public partial class ProductDetail : UserControl
    {
        private readonly BunifuTransition _bunifuTransition;
        private bool _havePrice = true;
        public ProductDetail()
        {
            InitializeComponent();
            OptimizeFormRendering();
            _bunifuTransition = new BunifuTransition();

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
        public async Task InitializeDetailData(Product product)
        {
            lbl_productDesc.Text = product.Description;
            lbl_productName.Text = product.Name;
            lbl_productMaintext.Text = product.MainText;
            if (product.Price != 0)
            {
                lbl_productPrice.Text = product.Price?.ToString("N0");
            }
            else
            {
                lbl_productPrice.Text = "";
                _havePrice = false;
            }
        }
        public async Task ShowDetail()
        {
            var lbl = new[]
            {
                lbl_productDesc,lbl_productMaintext,lbl_productName,lbl_productPrice
            }.ToList();
            var randomAnimation = Helper.GetRandomAnimations();
            _bunifuTransition.MaxAnimationTime = 2500;
            if (!_havePrice)
            {
                lbl.Remove(lbl_productPrice);
            }
            for (int i = 0; i < lbl.Count; i++)
            {
                _bunifuTransition.ShowSync(lbl[i], false, randomAnimation[i]);
            }
            await Task.Delay(100);

        }
    }
}
