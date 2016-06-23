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

            // Loads all data from the database
            Boot.LoadAll();
            Artikel.LoadAll();
            Vaarwater.LoadAll();
            HuurContract.LoadAll();

            ShowData();
        }

        /// <summary>
        /// Takes the bindinglists as datasources for the listboxes
        /// </summary>
        private void ShowData()
        {
            lb_Boten.DataSource = Boot.Boten;
            lb_Huurcontracten.DataSource = HuurContract.HuurContracten;
        }

        /// <summary>
        /// Form method that redirects to the HuurcontractForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Nieuw_Click(object sender, EventArgs e)
        {
            HuurcontractForm hcf = new HuurcontractForm();
            hcf.Show();
        }

        /// <summary>
        /// Form method that changes the boot values accordingly to its given instance
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lb_Boten_SelectedIndexChanged(object sender, EventArgs e)
        {
            Boot boot = (Boot) lb_Boten.SelectedItem;
            lbl_ShowBootNaam.Text = boot.Naam;
            lbl_ShowBootSoort.Text = boot.Soort;
            lbl_ShowBootAandrijving.Text = boot.Aandrijving;
            lbl_ShowBoottype.Text = boot.GetBoottypeNaam(boot);
            lbl_ShowActieradius.Text = boot.GetActieRadius(boot).ToString();
        }

        /// <summary>
        /// Form method that changes the huurcontract values accordingly to its given instance
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lb_Huurcontracten_SelectedIndexChanged(object sender, EventArgs e)
        {
            HuurContract hc = (HuurContract) lb_Huurcontracten.SelectedItem;
            lbl_ShowHCDatumStart.Text = hc.StartDatum.ToString("dd-MM-yyyy");
            lbl_ShowHCDatumEind.Text = hc.EindDatum.ToString("dd-MM-yyyy");
        }

        /// <summary>
        /// Form method that exports a huurcontract to a location of the users choosing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Export_Click(object sender, EventArgs e)
        {
            HuurContract hc = (HuurContract) lb_Huurcontracten.SelectedItem;
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Title = "Save Huurcontract";
                sfd.Filter = "JSON Files (*.json)|*.json";
                if (sfd.ShowDialog(this) == DialogResult.OK)
                {
                    hc.Export(hc, sfd.FileName);
                }
            }
        }

        /// <summary>
        /// Form method that redirects to the loginForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_LogIn_Click(object sender, EventArgs e)
        {
            LogInForm lif = new LogInForm();
            lif.Show();
        }
    }
}
