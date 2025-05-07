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
            //MessageBox.Show(bunifuVSlider1.Value
            //    .ToString());
            int valu = 0;
            if (valu!=bunifuVSlider1.Value)
            {
                valu = bunifuVSlider1.Value;
                var x = bunifuVSlider1.VerticalScroll.Value;
            }
            //int page = (int)Math.Round(); // اطمینان از عدد صحیح
            //LoadPage(page); // تابعی برای لود داده‌ها
        }
    }
}
