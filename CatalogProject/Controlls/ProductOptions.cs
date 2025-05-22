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
    public partial class ProductOptions : UserControl
    {
        private BunifuTransition _bunifuTransition;

        private int _optionCount;
        public ProductOptions()
        {
            InitializeComponent();
            OptimizeFormRendering();
            _bunifuTransition = new BunifuTransition();
            HideLbl();
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
        private void HideLbl()
        {
            var lbl = new[]
            {
                lbl_option1,lbl_option2,lbl_option3,lbl_option4,lbl_option5
            };
            foreach (var bunifuLabel in lbl)
            {
                bunifuLabel.Hide();
            }

        }
        public async Task initilizeOptionsData(List<Option> options)
        {

            _optionCount = options.Count;
            var lbl = new[]
            {
                lbl_option1,lbl_option2,lbl_option3,lbl_option4,lbl_option5
            };
            for (int i = 0; i < _optionCount; i++)
            {
                lbl[i].Text = options[i].Name + " : " + options[i].Value;
                lbl[i].Show();
            }
        }
        public async Task ShowOptions()
        {
            var lbl = new[]
            {
                lbl_option1,lbl_option2,lbl_option3,lbl_option4,lbl_option5
            };
            var randomAnimation = Helper.GetRandomAnimations();
            _bunifuTransition.MaxAnimationTime = 2500;
            for (int i = 0; i < _optionCount; i++)
            {
                _bunifuTransition.ShowSync(lbl[i], false, randomAnimation[i]);
            }
            await Task.Delay(100);

        }
    }
}
