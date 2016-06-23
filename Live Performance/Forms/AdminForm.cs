using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Live_Performance.Models;

namespace Live_Performance.Forms
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();

            ShowData();
        }

        private void ShowData()
        {
            lb_Boten.DataSource = Boot.Boten;
            lb_Artikelen.DataSource = Artikel.Artikelen;
            lb_Vaarwateren.DataSource = Vaarwater.Vaarwateren;
        }

        private void btn_AddVW_Click(object sender, EventArgs e)
        {
            AddVaarwaterForm avwf = new AddVaarwaterForm();
            avwf.Show();
        }
    }
}
