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
        public class User
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
        }
      
        private void DataSettingBtn_Click(object sender, EventArgs e)
        {
            CompanyList frmProductsList = new CompanyList();
            frmProductsList.ShowDialog();
        }
    }
}
