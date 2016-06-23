using System;
using System.Windows.Forms;
using Live_Performance.Models;

namespace Live_Performance.Forms
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Form method for logging in
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (User.Login(tb_username.Text, tb_password.Text))
            {
                AdminForm af = new AdminForm();
                af.Show();
                Close();
            }
            else
            {
                lbl_OnjuisteGegevens.Text = "U heeft onjuiste gegevens ingevuld";
            }
        }
    }
}
