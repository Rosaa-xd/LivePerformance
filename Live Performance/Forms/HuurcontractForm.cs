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
            if (Boot.BootTypeAllowed(boten) && !Vaarwater.VaarwaterenAllowed(vaarwateren))
            {
                vaarwateren.Add((Vaarwater)cb_Vaarwateren.SelectedItem);
            }
            else
            {
                MessageBox.Show("Spierkracht boten zijn hier niet toegestaan!");
            }
        }

        private void btn_CreateHC_Click(object sender, EventArgs e)
        {
            Vaarwater vaarwater = Vaarwater.VaarwaterBudget((double)nud_Vaarbudget.Value, boten, artikelen, vaarwateren);
            if (vaarwater == null)
            {
                MessageBox.Show("U kunt geen Friese meren bevaren");
            }
            else
            {
                MessageBox.Show("Het aantal Friese meren wat u kunt bevaren is " + vaarwater.Aantal);
                vaarwateren.Add(vaarwater);
            }

            if (dtp_Startdatum.Value > dtp_Einddatum.Value)
            {
                MessageBox.Show("Einddatum mag niet eerder zijn dan de startdatum!");
            }
            else
            {
                User user = new User(tb_HuurderNaam.Text, tb_Email.Text, tb_Wachtwoord.Text);
                user.SaveUser(user);
                HuurContract hc = new HuurContract(dtp_Startdatum.Value, dtp_Einddatum.Value, boten, artikelen, vaarwateren,
                    user);
                hc.SaveHuurContract(hc);
                HuurContract.HuurContracten.Add(hc);
                Close();
            }
        }

        private void lb_Boten_SelectedIndexChanged(object sender, EventArgs e)
        {
            Boot boot = (Boot)lb_Boten.SelectedItem;
            lbl_ShowBootNaam.Text = boot.Naam;
            lbl_ShowBootSoort.Text = boot.Soort;
            lbl_ShowBootAandrijving.Text = boot.Aandrijving;
            lbl_ShowBoottype.Text = boot.GetBoottypeNaam(boot);
            lbl_ShowActieradius.Text = boot.GetActieRadius(boot).ToString();
        }
    }
}
