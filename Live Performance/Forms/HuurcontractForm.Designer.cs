namespace Live_Performance.Forms
{
    partial class HuurcontractForm
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
            this.gb_Boten = new System.Windows.Forms.GroupBox();
            this.lbl_ShowActieradius = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_AddBoot = new System.Windows.Forms.Button();
            this.lbl_ShowBoottype = new System.Windows.Forms.Label();
            this.lbl_ShowBootAandrijving = new System.Windows.Forms.Label();
            this.lbl_ShowBootSoort = new System.Windows.Forms.Label();
            this.lbl_ShowBootNaam = new System.Windows.Forms.Label();
            this.lbl_boottype = new System.Windows.Forms.Label();
            this.lbl_bootaandrijving = new System.Windows.Forms.Label();
            this.lbl_Bootsoort = new System.Windows.Forms.Label();
            this.lbl_Bootnaam = new System.Windows.Forms.Label();
            this.lb_Boten = new System.Windows.Forms.ListBox();
            this.gb_Artikelen = new System.Windows.Forms.GroupBox();
            this.btn_AddArtikel = new System.Windows.Forms.Button();
            this.lb_Artikelen = new System.Windows.Forms.ListBox();
            this.gb_Info = new System.Windows.Forms.GroupBox();
            this.lbl_GekozenVaarwateren = new System.Windows.Forms.Label();
            this.lbl_vaarwaterenGekozen = new System.Windows.Forms.Label();
            this.btn_AddVaarwater = new System.Windows.Forms.Button();
            this.cb_Vaarwateren = new System.Windows.Forms.ComboBox();
            this.lbl_Vaarwateren = new System.Windows.Forms.Label();
            this.lbl_Vaarbudget = new System.Windows.Forms.Label();
            this.nud_Vaarbudget = new System.Windows.Forms.NumericUpDown();
            this.lbl_Einddatum = new System.Windows.Forms.Label();
            this.lbl_Startdatum = new System.Windows.Forms.Label();
            this.lbl_Wachtwoord = new System.Windows.Forms.Label();
            this.dtp_Einddatum = new System.Windows.Forms.DateTimePicker();
            this.dtp_Startdatum = new System.Windows.Forms.DateTimePicker();
            this.tb_Wachtwoord = new System.Windows.Forms.TextBox();
            this.tb_Email = new System.Windows.Forms.TextBox();
            this.tb_HuurderNaam = new System.Windows.Forms.TextBox();
            this.lbl_HuurderEmail = new System.Windows.Forms.Label();
            this.lbl_HuurderNaam = new System.Windows.Forms.Label();
            this.btn_CreateHC = new System.Windows.Forms.Button();
            this.gb_Boten.SuspendLayout();
            this.gb_Artikelen.SuspendLayout();
            this.gb_Info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Vaarbudget)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_Boten
            // 
            this.gb_Boten.Controls.Add(this.lbl_ShowActieradius);
            this.gb_Boten.Controls.Add(this.label1);
            this.gb_Boten.Controls.Add(this.btn_AddBoot);
            this.gb_Boten.Controls.Add(this.lbl_ShowBoottype);
            this.gb_Boten.Controls.Add(this.lbl_ShowBootAandrijving);
            this.gb_Boten.Controls.Add(this.lbl_ShowBootSoort);
            this.gb_Boten.Controls.Add(this.lbl_ShowBootNaam);
            this.gb_Boten.Controls.Add(this.lbl_boottype);
            this.gb_Boten.Controls.Add(this.lbl_bootaandrijving);
            this.gb_Boten.Controls.Add(this.lbl_Bootsoort);
            this.gb_Boten.Controls.Add(this.lbl_Bootnaam);
            this.gb_Boten.Controls.Add(this.lb_Boten);
            this.gb_Boten.Location = new System.Drawing.Point(12, 12);
            this.gb_Boten.Name = "gb_Boten";
            this.gb_Boten.Size = new System.Drawing.Size(385, 385);
            this.gb_Boten.TabIndex = 1;
            this.gb_Boten.TabStop = false;
            this.gb_Boten.Text = "Boten";
            // 
            // lbl_ShowActieradius
            // 
            this.lbl_ShowActieradius.AutoSize = true;
            this.lbl_ShowActieradius.Location = new System.Drawing.Point(270, 128);
            this.lbl_ShowActieradius.Name = "lbl_ShowActieradius";
            this.lbl_ShowActieradius.Size = new System.Drawing.Size(12, 13);
            this.lbl_ShowActieradius.TabIndex = 11;
            this.lbl_ShowActieradius.Text = "x";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Actieradius: ";
            // 
            // btn_AddBoot
            // 
            this.btn_AddBoot.Location = new System.Drawing.Point(304, 352);
            this.btn_AddBoot.Name = "btn_AddBoot";
            this.btn_AddBoot.Size = new System.Drawing.Size(75, 23);
            this.btn_AddBoot.TabIndex = 9;
            this.btn_AddBoot.Text = "Toevoegen";
            this.btn_AddBoot.UseVisualStyleBackColor = true;
            this.btn_AddBoot.Click += new System.EventHandler(this.btn_AddBoot_Click);
            // 
            // lbl_ShowBoottype
            // 
            this.lbl_ShowBoottype.AutoSize = true;
            this.lbl_ShowBoottype.Location = new System.Drawing.Point(270, 106);
            this.lbl_ShowBoottype.Name = "lbl_ShowBoottype";
            this.lbl_ShowBoottype.Size = new System.Drawing.Size(12, 13);
            this.lbl_ShowBoottype.TabIndex = 8;
            this.lbl_ShowBoottype.Text = "x";
            // 
            // lbl_ShowBootAandrijving
            // 
            this.lbl_ShowBootAandrijving.AutoSize = true;
            this.lbl_ShowBootAandrijving.Location = new System.Drawing.Point(270, 84);
            this.lbl_ShowBootAandrijving.Name = "lbl_ShowBootAandrijving";
            this.lbl_ShowBootAandrijving.Size = new System.Drawing.Size(12, 13);
            this.lbl_ShowBootAandrijving.TabIndex = 7;
            this.lbl_ShowBootAandrijving.Text = "x";
            // 
            // lbl_ShowBootSoort
            // 
            this.lbl_ShowBootSoort.AutoSize = true;
            this.lbl_ShowBootSoort.Location = new System.Drawing.Point(270, 62);
            this.lbl_ShowBootSoort.Name = "lbl_ShowBootSoort";
            this.lbl_ShowBootSoort.Size = new System.Drawing.Size(12, 13);
            this.lbl_ShowBootSoort.TabIndex = 6;
            this.lbl_ShowBootSoort.Text = "x";
            // 
            // lbl_ShowBootNaam
            // 
            this.lbl_ShowBootNaam.AutoSize = true;
            this.lbl_ShowBootNaam.Location = new System.Drawing.Point(270, 40);
            this.lbl_ShowBootNaam.Name = "lbl_ShowBootNaam";
            this.lbl_ShowBootNaam.Size = new System.Drawing.Size(12, 13);
            this.lbl_ShowBootNaam.TabIndex = 5;
            this.lbl_ShowBootNaam.Text = "x";
            // 
            // lbl_boottype
            // 
            this.lbl_boottype.AutoSize = true;
            this.lbl_boottype.Location = new System.Drawing.Point(202, 106);
            this.lbl_boottype.Name = "lbl_boottype";
            this.lbl_boottype.Size = new System.Drawing.Size(52, 13);
            this.lbl_boottype.TabIndex = 4;
            this.lbl_boottype.Text = "Boottype:";
            // 
            // lbl_bootaandrijving
            // 
            this.lbl_bootaandrijving.AutoSize = true;
            this.lbl_bootaandrijving.Location = new System.Drawing.Point(202, 84);
            this.lbl_bootaandrijving.Name = "lbl_bootaandrijving";
            this.lbl_bootaandrijving.Size = new System.Drawing.Size(62, 13);
            this.lbl_bootaandrijving.TabIndex = 3;
            this.lbl_bootaandrijving.Text = "Aandrijving:";
            // 
            // lbl_Bootsoort
            // 
            this.lbl_Bootsoort.AutoSize = true;
            this.lbl_Bootsoort.Location = new System.Drawing.Point(202, 62);
            this.lbl_Bootsoort.Name = "lbl_Bootsoort";
            this.lbl_Bootsoort.Size = new System.Drawing.Size(35, 13);
            this.lbl_Bootsoort.TabIndex = 2;
            this.lbl_Bootsoort.Text = "Soort:";
            // 
            // lbl_Bootnaam
            // 
            this.lbl_Bootnaam.AutoSize = true;
            this.lbl_Bootnaam.Location = new System.Drawing.Point(202, 40);
            this.lbl_Bootnaam.Name = "lbl_Bootnaam";
            this.lbl_Bootnaam.Size = new System.Drawing.Size(38, 13);
            this.lbl_Bootnaam.TabIndex = 1;
            this.lbl_Bootnaam.Text = "Naam:";
            // 
            // lb_Boten
            // 
            this.lb_Boten.FormattingEnabled = true;
            this.lb_Boten.Location = new System.Drawing.Point(7, 20);
            this.lb_Boten.Name = "lb_Boten";
            this.lb_Boten.Size = new System.Drawing.Size(189, 355);
            this.lb_Boten.TabIndex = 0;
            this.lb_Boten.SelectedIndexChanged += new System.EventHandler(this.lb_Boten_SelectedIndexChanged);
            // 
            // gb_Artikelen
            // 
            this.gb_Artikelen.Controls.Add(this.btn_AddArtikel);
            this.gb_Artikelen.Controls.Add(this.lb_Artikelen);
            this.gb_Artikelen.Location = new System.Drawing.Point(403, 12);
            this.gb_Artikelen.Name = "gb_Artikelen";
            this.gb_Artikelen.Size = new System.Drawing.Size(284, 385);
            this.gb_Artikelen.TabIndex = 2;
            this.gb_Artikelen.TabStop = false;
            this.gb_Artikelen.Text = "Artikelen";
            // 
            // btn_AddArtikel
            // 
            this.btn_AddArtikel.Location = new System.Drawing.Point(202, 352);
            this.btn_AddArtikel.Name = "btn_AddArtikel";
            this.btn_AddArtikel.Size = new System.Drawing.Size(75, 23);
            this.btn_AddArtikel.TabIndex = 1;
            this.btn_AddArtikel.Text = "Toevoegen";
            this.btn_AddArtikel.UseVisualStyleBackColor = true;
            this.btn_AddArtikel.Click += new System.EventHandler(this.btn_AddArtikel_Click);
            // 
            // lb_Artikelen
            // 
            this.lb_Artikelen.FormattingEnabled = true;
            this.lb_Artikelen.Location = new System.Drawing.Point(7, 20);
            this.lb_Artikelen.Name = "lb_Artikelen";
            this.lb_Artikelen.Size = new System.Drawing.Size(189, 355);
            this.lb_Artikelen.TabIndex = 0;
            // 
            // gb_Info
            // 
            this.gb_Info.Controls.Add(this.lbl_GekozenVaarwateren);
            this.gb_Info.Controls.Add(this.lbl_vaarwaterenGekozen);
            this.gb_Info.Controls.Add(this.btn_AddVaarwater);
            this.gb_Info.Controls.Add(this.cb_Vaarwateren);
            this.gb_Info.Controls.Add(this.lbl_Vaarwateren);
            this.gb_Info.Controls.Add(this.lbl_Vaarbudget);
            this.gb_Info.Controls.Add(this.nud_Vaarbudget);
            this.gb_Info.Controls.Add(this.lbl_Einddatum);
            this.gb_Info.Controls.Add(this.lbl_Startdatum);
            this.gb_Info.Controls.Add(this.lbl_Wachtwoord);
            this.gb_Info.Controls.Add(this.dtp_Einddatum);
            this.gb_Info.Controls.Add(this.dtp_Startdatum);
            this.gb_Info.Controls.Add(this.tb_Wachtwoord);
            this.gb_Info.Controls.Add(this.tb_Email);
            this.gb_Info.Controls.Add(this.tb_HuurderNaam);
            this.gb_Info.Controls.Add(this.lbl_HuurderEmail);
            this.gb_Info.Controls.Add(this.lbl_HuurderNaam);
            this.gb_Info.Location = new System.Drawing.Point(693, 12);
            this.gb_Info.Name = "gb_Info";
            this.gb_Info.Size = new System.Drawing.Size(269, 355);
            this.gb_Info.TabIndex = 3;
            this.gb_Info.TabStop = false;
            this.gb_Info.Text = "Informatie";
            // 
            // lbl_GekozenVaarwateren
            // 
            this.lbl_GekozenVaarwateren.AutoSize = true;
            this.lbl_GekozenVaarwateren.Location = new System.Drawing.Point(10, 250);
            this.lbl_GekozenVaarwateren.Name = "lbl_GekozenVaarwateren";
            this.lbl_GekozenVaarwateren.Size = new System.Drawing.Size(12, 13);
            this.lbl_GekozenVaarwateren.TabIndex = 17;
            this.lbl_GekozenVaarwateren.Text = "x";
            // 
            // lbl_vaarwaterenGekozen
            // 
            this.lbl_vaarwaterenGekozen.AutoSize = true;
            this.lbl_vaarwaterenGekozen.Location = new System.Drawing.Point(10, 237);
            this.lbl_vaarwaterenGekozen.Name = "lbl_vaarwaterenGekozen";
            this.lbl_vaarwaterenGekozen.Size = new System.Drawing.Size(115, 13);
            this.lbl_vaarwaterenGekozen.TabIndex = 16;
            this.lbl_vaarwaterenGekozen.Text = "Gekozen vaarwateren:";
            // 
            // btn_AddVaarwater
            // 
            this.btn_AddVaarwater.Location = new System.Drawing.Point(183, 206);
            this.btn_AddVaarwater.Name = "btn_AddVaarwater";
            this.btn_AddVaarwater.Size = new System.Drawing.Size(75, 23);
            this.btn_AddVaarwater.TabIndex = 15;
            this.btn_AddVaarwater.Text = "Toevoegen";
            this.btn_AddVaarwater.UseVisualStyleBackColor = true;
            this.btn_AddVaarwater.Click += new System.EventHandler(this.btn_AddVaarwater_Click);
            // 
            // cb_Vaarwateren
            // 
            this.cb_Vaarwateren.FormattingEnabled = true;
            this.cb_Vaarwateren.Location = new System.Drawing.Point(84, 179);
            this.cb_Vaarwateren.Name = "cb_Vaarwateren";
            this.cb_Vaarwateren.Size = new System.Drawing.Size(174, 21);
            this.cb_Vaarwateren.TabIndex = 14;
            // 
            // lbl_Vaarwateren
            // 
            this.lbl_Vaarwateren.AutoSize = true;
            this.lbl_Vaarwateren.Location = new System.Drawing.Point(7, 182);
            this.lbl_Vaarwateren.Name = "lbl_Vaarwateren";
            this.lbl_Vaarwateren.Size = new System.Drawing.Size(70, 13);
            this.lbl_Vaarwateren.TabIndex = 13;
            this.lbl_Vaarwateren.Text = "Vaarwateren:";
            // 
            // lbl_Vaarbudget
            // 
            this.lbl_Vaarbudget.AutoSize = true;
            this.lbl_Vaarbudget.Location = new System.Drawing.Point(7, 154);
            this.lbl_Vaarbudget.Name = "lbl_Vaarbudget";
            this.lbl_Vaarbudget.Size = new System.Drawing.Size(65, 13);
            this.lbl_Vaarbudget.TabIndex = 11;
            this.lbl_Vaarbudget.Text = "Vaarbudget:";
            // 
            // nud_Vaarbudget
            // 
            this.nud_Vaarbudget.Location = new System.Drawing.Point(84, 152);
            this.nud_Vaarbudget.Name = "nud_Vaarbudget";
            this.nud_Vaarbudget.Size = new System.Drawing.Size(174, 20);
            this.nud_Vaarbudget.TabIndex = 10;
            // 
            // lbl_Einddatum
            // 
            this.lbl_Einddatum.AutoSize = true;
            this.lbl_Einddatum.Location = new System.Drawing.Point(7, 131);
            this.lbl_Einddatum.Name = "lbl_Einddatum";
            this.lbl_Einddatum.Size = new System.Drawing.Size(60, 13);
            this.lbl_Einddatum.TabIndex = 9;
            this.lbl_Einddatum.Text = "Einddatum:";
            // 
            // lbl_Startdatum
            // 
            this.lbl_Startdatum.AutoSize = true;
            this.lbl_Startdatum.Location = new System.Drawing.Point(7, 104);
            this.lbl_Startdatum.Name = "lbl_Startdatum";
            this.lbl_Startdatum.Size = new System.Drawing.Size(61, 13);
            this.lbl_Startdatum.TabIndex = 8;
            this.lbl_Startdatum.Text = "Startdatum:";
            // 
            // lbl_Wachtwoord
            // 
            this.lbl_Wachtwoord.AutoSize = true;
            this.lbl_Wachtwoord.Location = new System.Drawing.Point(7, 74);
            this.lbl_Wachtwoord.Name = "lbl_Wachtwoord";
            this.lbl_Wachtwoord.Size = new System.Drawing.Size(71, 13);
            this.lbl_Wachtwoord.TabIndex = 7;
            this.lbl_Wachtwoord.Text = "Wachtwoord:";
            // 
            // dtp_Einddatum
            // 
            this.dtp_Einddatum.Location = new System.Drawing.Point(84, 125);
            this.dtp_Einddatum.Name = "dtp_Einddatum";
            this.dtp_Einddatum.Size = new System.Drawing.Size(174, 20);
            this.dtp_Einddatum.TabIndex = 6;
            // 
            // dtp_Startdatum
            // 
            this.dtp_Startdatum.Location = new System.Drawing.Point(84, 98);
            this.dtp_Startdatum.Name = "dtp_Startdatum";
            this.dtp_Startdatum.Size = new System.Drawing.Size(174, 20);
            this.dtp_Startdatum.TabIndex = 5;
            // 
            // tb_Wachtwoord
            // 
            this.tb_Wachtwoord.Location = new System.Drawing.Point(84, 71);
            this.tb_Wachtwoord.Name = "tb_Wachtwoord";
            this.tb_Wachtwoord.Size = new System.Drawing.Size(174, 20);
            this.tb_Wachtwoord.TabIndex = 4;
            // 
            // tb_Email
            // 
            this.tb_Email.Location = new System.Drawing.Point(84, 44);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(174, 20);
            this.tb_Email.TabIndex = 3;
            // 
            // tb_HuurderNaam
            // 
            this.tb_HuurderNaam.Location = new System.Drawing.Point(84, 18);
            this.tb_HuurderNaam.Name = "tb_HuurderNaam";
            this.tb_HuurderNaam.Size = new System.Drawing.Size(174, 20);
            this.tb_HuurderNaam.TabIndex = 2;
            // 
            // lbl_HuurderEmail
            // 
            this.lbl_HuurderEmail.AutoSize = true;
            this.lbl_HuurderEmail.Location = new System.Drawing.Point(7, 47);
            this.lbl_HuurderEmail.Name = "lbl_HuurderEmail";
            this.lbl_HuurderEmail.Size = new System.Drawing.Size(38, 13);
            this.lbl_HuurderEmail.TabIndex = 1;
            this.lbl_HuurderEmail.Text = "E-mail:";
            // 
            // lbl_HuurderNaam
            // 
            this.lbl_HuurderNaam.AutoSize = true;
            this.lbl_HuurderNaam.Location = new System.Drawing.Point(7, 20);
            this.lbl_HuurderNaam.Name = "lbl_HuurderNaam";
            this.lbl_HuurderNaam.Size = new System.Drawing.Size(38, 13);
            this.lbl_HuurderNaam.TabIndex = 0;
            this.lbl_HuurderNaam.Text = "Naam:";
            // 
            // btn_CreateHC
            // 
            this.btn_CreateHC.Location = new System.Drawing.Point(887, 373);
            this.btn_CreateHC.Name = "btn_CreateHC";
            this.btn_CreateHC.Size = new System.Drawing.Size(75, 23);
            this.btn_CreateHC.TabIndex = 4;
            this.btn_CreateHC.Text = "Bevestig";
            this.btn_CreateHC.UseVisualStyleBackColor = true;
            this.btn_CreateHC.Click += new System.EventHandler(this.btn_CreateHC_Click);
            // 
            // HuurcontractForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 409);
            this.Controls.Add(this.btn_CreateHC);
            this.Controls.Add(this.gb_Info);
            this.Controls.Add(this.gb_Artikelen);
            this.Controls.Add(this.gb_Boten);
            this.Name = "HuurcontractForm";
            this.Text = "HuurcontractForm";
            this.gb_Boten.ResumeLayout(false);
            this.gb_Boten.PerformLayout();
            this.gb_Artikelen.ResumeLayout(false);
            this.gb_Info.ResumeLayout(false);
            this.gb_Info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Vaarbudget)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Boten;
        private System.Windows.Forms.Label lbl_ShowBoottype;
        private System.Windows.Forms.Label lbl_ShowBootAandrijving;
        private System.Windows.Forms.Label lbl_ShowBootSoort;
        private System.Windows.Forms.Label lbl_ShowBootNaam;
        private System.Windows.Forms.Label lbl_boottype;
        private System.Windows.Forms.Label lbl_bootaandrijving;
        private System.Windows.Forms.Label lbl_Bootsoort;
        private System.Windows.Forms.Label lbl_Bootnaam;
        private System.Windows.Forms.ListBox lb_Boten;
        private System.Windows.Forms.GroupBox gb_Artikelen;
        private System.Windows.Forms.ListBox lb_Artikelen;
        private System.Windows.Forms.Button btn_AddBoot;
        private System.Windows.Forms.Button btn_AddArtikel;
        private System.Windows.Forms.GroupBox gb_Info;
        private System.Windows.Forms.Label lbl_GekozenVaarwateren;
        private System.Windows.Forms.Label lbl_vaarwaterenGekozen;
        private System.Windows.Forms.Button btn_AddVaarwater;
        private System.Windows.Forms.ComboBox cb_Vaarwateren;
        private System.Windows.Forms.Label lbl_Vaarwateren;
        private System.Windows.Forms.Label lbl_Vaarbudget;
        private System.Windows.Forms.NumericUpDown nud_Vaarbudget;
        private System.Windows.Forms.Label lbl_Einddatum;
        private System.Windows.Forms.Label lbl_Startdatum;
        private System.Windows.Forms.Label lbl_Wachtwoord;
        private System.Windows.Forms.DateTimePicker dtp_Einddatum;
        private System.Windows.Forms.DateTimePicker dtp_Startdatum;
        private System.Windows.Forms.TextBox tb_Wachtwoord;
        private System.Windows.Forms.TextBox tb_Email;
        private System.Windows.Forms.TextBox tb_HuurderNaam;
        private System.Windows.Forms.Label lbl_HuurderEmail;
        private System.Windows.Forms.Label lbl_HuurderNaam;
        private System.Windows.Forms.Button btn_CreateHC;
        private System.Windows.Forms.Label lbl_ShowActieradius;
        private System.Windows.Forms.Label label1;
    }
}