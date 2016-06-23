namespace Live_Performance.Forms
{
    partial class LogInForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Username = new System.Windows.Forms.Label();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.lbl_Wachtwoord = new System.Windows.Forms.Label();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.lbl_OnjuisteGegevens = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Location = new System.Drawing.Point(12, 34);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(38, 13);
            this.lbl_Username.TabIndex = 0;
            this.lbl_Username.Text = "Naam:";
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(89, 34);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(161, 20);
            this.tb_username.TabIndex = 1;
            // 
            // lbl_Wachtwoord
            // 
            this.lbl_Wachtwoord.AutoSize = true;
            this.lbl_Wachtwoord.Location = new System.Drawing.Point(12, 66);
            this.lbl_Wachtwoord.Name = "lbl_Wachtwoord";
            this.lbl_Wachtwoord.Size = new System.Drawing.Size(71, 13);
            this.lbl_Wachtwoord.TabIndex = 2;
            this.lbl_Wachtwoord.Text = "Wachtwoord:";
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(89, 60);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(161, 20);
            this.tb_password.TabIndex = 3;
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(101, 89);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(75, 23);
            this.btn_Login.TabIndex = 4;
            this.btn_Login.Text = "Log In";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // lbl_OnjuisteGegevens
            // 
            this.lbl_OnjuisteGegevens.AutoSize = true;
            this.lbl_OnjuisteGegevens.Location = new System.Drawing.Point(33, 9);
            this.lbl_OnjuisteGegevens.Name = "lbl_OnjuisteGegevens";
            this.lbl_OnjuisteGegevens.Size = new System.Drawing.Size(0, 13);
            this.lbl_OnjuisteGegevens.TabIndex = 5;
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 128);
            this.Controls.Add(this.lbl_OnjuisteGegevens);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.lbl_Wachtwoord);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.lbl_Username);
            this.Name = "LogInForm";
            this.Text = "LogInForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.Label lbl_Wachtwoord;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Label lbl_OnjuisteGegevens;
    }
}