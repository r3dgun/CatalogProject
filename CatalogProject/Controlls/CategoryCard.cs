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
    public partial class CategoryCard : UserControl
    {
        public CategoryCard()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.OptimizedDoubleBuffer |
                          ControlStyles.UserPaint, true);
            this.UpdateStyles();
            tableLayoutPanel.SuspendLayout();
            tableLayoutPanel.ResumeLayout();
            if (this.bunifuGradientPanel != null)
            {
                Pic_Box.Click += (s, e) => this.OnClick(e);

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
            bunifuCard.Visible = true;
            lbl_CategoryName.Text = "نام دسته :" + @"  " + category.Name;
            lbl_CategoryDisc.Text = "توضیحات :" + @"  " + category.Description;
            Pic_Box.Image = Helper.LoadImageFromPath(category.Image, Helper.PathName.CategoryImage);
        }
        public void HideCartDetail()
        {
            bunifuCard.Visible = false;

        }
    }
}
