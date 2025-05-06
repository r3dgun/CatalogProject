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
using CatalogProject.ProductFroms;
using LiteDB;

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
            CompanyListFrm frmProductsList = new CompanyListFrm();
            this.Hide();
            frmProductsList.ShowDialog();
            this.Show();
        }
    }
}
