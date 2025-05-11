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
using CatalogProject.Forms.CategoryForm;
using CatalogProject.Forms.CompanyForm;
using CatalogProject.Forms.ShowingForms;
using CatalogProject.ProductFroms;
using LiteDB;
using Microsoft.Extensions.DependencyInjection;

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
    }
}
