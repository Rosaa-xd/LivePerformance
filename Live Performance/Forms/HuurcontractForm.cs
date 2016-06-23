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
    public partial class HuurcontractForm : Form
    {
        private List<Boot> boten = new List<Boot>();
        private List<Artikel> artikelen = new List<Artikel>();
        private List<Vaarwater> vaarwateren = new List<Vaarwater>(); 

        public HuurcontractForm()
        {
            InitializeComponent();
            ShowData();
        }

        private void ShowData()
        {
            lb_Boten.DataSource = Boot.Boten;
            lb_Artikelen.DataSource = Artikel.Artikelen;
            cb_Vaarwateren.DataSource = Vaarwater.Vaarwateren;
        }

        private void btn_AddBoot_Click(object sender, EventArgs e)
        {
            boten.Add((Boot) lb_Boten.SelectedItem);
        }

        private void btn_AddArtikel_Click(object sender, EventArgs e)
        {
            artikelen.Add((Artikel) lb_Artikelen.SelectedItem);
        }

        private void btn_AddVaarwater_Click(object sender, EventArgs e)
        {
            vaarwateren.Add((Vaarwater) cb_Vaarwateren.SelectedItem);
        }

        private void btn_CreateHC_Click(object sender, EventArgs e)
        {
            User user = new User(tb_HuurderNaam.Text, tb_Email.Text, tb_Wachtwoord.Text);
            user.SaveUser(user);
            HuurContract hc = new HuurContract(dtp_Startdatum.Value, dtp_Einddatum.Value, boten, artikelen, vaarwateren,
                user);
            hc.SaveHuurContract(hc);
        }
    }
}
