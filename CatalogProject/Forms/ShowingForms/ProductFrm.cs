using Bunifu.Framework.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.UI.WinForms.BunifuAnimatorNS;

namespace CatalogProject.Forms.ShowingForms
{
    public partial class ProductFrm : Form
    {
        public ProductFrm()
        {
            InitializeComponent();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            bunifuTransition1.ShowSync(bunifuCards1, false, Animation.Mosaic);

        }
    }
}
