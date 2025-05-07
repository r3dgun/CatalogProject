using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;

namespace CatalogProject.Forms.ShowingForms
{
    public partial class CompaniesFrm : Form
    {
        private readonly List<Company> _companies;
        public CompaniesFrm( List<Company> companies)
        {
            InitializeComponent();
            _companies = companies;
        }

  
        private void bunifuVSlider1_ValueChanged(object sender, Utilities.BunifuSlider.BunifuVScrollBar.ValueChangedEventArgs e)
        {
         
        }
    }
}
