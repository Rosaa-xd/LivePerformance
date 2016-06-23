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
    public partial class AddVaarwaterForm : Form
    {
        public AddVaarwaterForm()
        {
            InitializeComponent();
        }

        private void btn_AddVaarwater_Click(object sender, EventArgs e)
        {
            if (tb_vwNaam != null)
            {
                //Prijs is even hardcoded vanwege tijdgebrek, dit moet later een dropdownlist vormen of toegevoegd worden met een nieuw form
                Vaarwater vaarwater = new Vaarwater(tb_vwNaam.Text, new Prijs(4, 2));
                vaarwater.Save(vaarwater);
                Close();
            }
            else
            {
                MessageBox.Show("Graag een naam invoeren :) ");
            }
        }
    }
}
