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
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();

            Boot.LoadAll();
            Artikel.LoadAll();
            Vaarwater.LoadAll();
            HuurContract.LoadAll();

            ShowData();
        }

        private void ShowData()
        {
            lb_Boten.DataSource = Boot.Boten;
            lb_Huurcontracten.DataSource = HuurContract.HuurContracten;
        }

        private void btn_Nieuw_Click(object sender, EventArgs e)
        {
            HuurcontractForm hcf = new HuurcontractForm();
            hcf.Show();
        }

        private void lb_Boten_SelectedIndexChanged(object sender, EventArgs e)
        {
            Boot boot = (Boot) lb_Boten.SelectedItem;
            lbl_ShowBootNaam.Text = boot.Naam;
            lbl_ShowBootSoort.Text = boot.Soort;
            lbl_ShowBootAandrijving.Text = boot.Aandrijving;
            lbl_ShowBoottype.Text = boot.GetBoottypeNaam(boot);
            lbl_ShowActieradius.Text = boot.GetActieRadius(boot).ToString();
        }

        private void lb_Huurcontracten_SelectedIndexChanged(object sender, EventArgs e)
        {
            HuurContract hc = (HuurContract) lb_Huurcontracten.SelectedItem;
            lbl_ShowHCDatumStart.Text = hc.StartDatum.ToString("dd-MM-yyyy");
            lbl_ShowHCDatumEind.Text = hc.EindDatum.ToString("dd-MM-yyyy");
        }
    }
}
