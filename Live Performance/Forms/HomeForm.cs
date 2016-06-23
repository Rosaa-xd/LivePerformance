﻿using System;
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
        }

        private void btn_Nieuw_Click(object sender, EventArgs e)
        {
            HuurcontractForm hcf = new HuurcontractForm();
            hcf.Show();
        }
    }
}
