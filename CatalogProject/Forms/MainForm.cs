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
using BunifuGradientPanelDemo;
using CatalogProject.Forms.CategoryForm;
using CatalogProject.Forms.CompanyForm;
using CatalogProject.Forms.ShowingForms;
using CatalogProject.ProductFroms;
using LiteDB;
using Microsoft.Extensions.DependencyInjection;
using Models;

namespace CatalogProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
           
        }
       
      
        private void DataSettingBtn_Click(object sender, EventArgs e)
        {
            var frmProductsList = Program.ServiceProvider.GetRequiredService<CompanyListFrm>();
            this.Hide();
            frmProductsList.ShowDialog();
            this.Show();
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            var companiesFrm = Program.ServiceProvider.GetRequiredService<CompaniesFrm>();
            companiesFrm.ShowDialog();
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            var companiesFrm = Program.ServiceProvider.GetRequiredService<ProductFrm>();
            companiesFrm.ShowDialog();
            
        }

        private void btnCompanySetting_Click(object sender, EventArgs e)
        {
            var pageSettingFrm = Program.ServiceProvider.GetRequiredService<PageSettingFrm>();
            pageSettingFrm.InitializeData(FormName.Company);
            pageSettingFrm.ShowDialog();

        }

        private void btnProductsSetting_Click(object sender, EventArgs e)
        {
            var pageSettingFrm = Program.ServiceProvider.GetRequiredService<PageSettingFrm>();
            pageSettingFrm.InitializeData(FormName.Products);
            pageSettingFrm.ShowDialog();
        }

        private void btnProductSetting_Click(object sender, EventArgs e)
        {
            var pageSettingFrm = Program.ServiceProvider.GetRequiredService<PageSettingFrm>();
            pageSettingFrm.InitializeData(FormName.Product);
            pageSettingFrm.ShowDialog();
        }

        private void btnCategorySetting_Click(object sender, EventArgs e)
        {
            var pageSettingFrm = Program.ServiceProvider.GetRequiredService<PageSettingFrm>();
            pageSettingFrm.InitializeData(FormName.Category);
            pageSettingFrm.ShowDialog();
        }
    }
}
