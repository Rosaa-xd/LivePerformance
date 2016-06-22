namespace Live_Performance.Forms
{
    partial class AdminForm
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
            this.btn_EditBoot = new System.Windows.Forms.Button();
            this.btn_DeleteBoot = new System.Windows.Forms.Button();
            this.btn_EditArtikel = new System.Windows.Forms.Button();
            this.btn_DeleteArtikel = new System.Windows.Forms.Button();
            this.lbl_Prijs = new System.Windows.Forms.Label();
            this.lbl_ShowPrijs = new System.Windows.Forms.Label();
            this.lbl_ShowPrijsArt = new System.Windows.Forms.Label();
            this.lbl_ShowNaam = new System.Windows.Forms.Label();
            this.lbl_ArtPrijs = new System.Windows.Forms.Label();
            this.lbl_Naam = new System.Windows.Forms.Label();
            this.gb_Wateren = new System.Windows.Forms.GroupBox();
            this.lbl_ShowPrijsVW = new System.Windows.Forms.Label();
            this.lbl_NaamVW = new System.Windows.Forms.Label();
            this.lbl_PrijsVW = new System.Windows.Forms.Label();
            this.lbl_NaamVaarwater = new System.Windows.Forms.Label();
            this.btn_AddVW = new System.Windows.Forms.Button();
            this.lb_Vaarwateren = new System.Windows.Forms.ListBox();
            this.btn_Back = new System.Windows.Forms.Button();
            this.gb_Boten.SuspendLayout();
            this.gb_Artikelen.SuspendLayout();
            this.gb_Wateren.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Boten
            // 
            this.gb_Boten.Controls.Add(this.lbl_ShowPrijs);
            this.gb_Boten.Controls.Add(this.lbl_Prijs);
            this.gb_Boten.Controls.Add(this.btn_DeleteBoot);
            this.gb_Boten.Controls.Add(this.btn_EditBoot);
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
            this.gb_Boten.TabIndex = 2;
            this.gb_Boten.TabStop = false;
            this.gb_Boten.Text = "Boten";
            // 
            // btn_AddBoot
            // 
            this.btn_AddBoot.Location = new System.Drawing.Point(304, 294);
            this.btn_AddBoot.Name = "btn_AddBoot";
            this.btn_AddBoot.Size = new System.Drawing.Size(75, 23);
            this.btn_AddBoot.TabIndex = 9;
            this.btn_AddBoot.Text = "Toevoegen";
            this.btn_AddBoot.UseVisualStyleBackColor = true;
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
            // 
            // gb_Artikelen
            // 
            this.gb_Artikelen.Controls.Add(this.lbl_ShowPrijsArt);
            this.gb_Artikelen.Controls.Add(this.lbl_ShowNaam);
            this.gb_Artikelen.Controls.Add(this.lbl_ArtPrijs);
            this.gb_Artikelen.Controls.Add(this.lbl_Naam);
            this.gb_Artikelen.Controls.Add(this.btn_DeleteArtikel);
            this.gb_Artikelen.Controls.Add(this.btn_EditArtikel);
            this.gb_Artikelen.Controls.Add(this.btn_AddArtikel);
            this.gb_Artikelen.Controls.Add(this.lb_Artikelen);
            this.gb_Artikelen.Location = new System.Drawing.Point(403, 12);
            this.gb_Artikelen.Name = "gb_Artikelen";
            this.gb_Artikelen.Size = new System.Drawing.Size(385, 385);
            this.gb_Artikelen.TabIndex = 3;
            this.gb_Artikelen.TabStop = false;
            this.gb_Artikelen.Text = "Artikelen";
            // 
            // btn_AddArtikel
            // 
            this.btn_AddArtikel.Location = new System.Drawing.Point(304, 294);
            this.btn_AddArtikel.Name = "btn_AddArtikel";
            this.btn_AddArtikel.Size = new System.Drawing.Size(75, 23);
            this.btn_AddArtikel.TabIndex = 1;
            this.btn_AddArtikel.Text = "Toevoegen";
            this.btn_AddArtikel.UseVisualStyleBackColor = true;
            // 
            // lb_Artikelen
            // 
            this.lb_Artikelen.FormattingEnabled = true;
            this.lb_Artikelen.Location = new System.Drawing.Point(7, 20);
            this.lb_Artikelen.Name = "lb_Artikelen";
            this.lb_Artikelen.Size = new System.Drawing.Size(189, 355);
            this.lb_Artikelen.TabIndex = 0;
            // 
            // btn_EditBoot
            // 
            this.btn_EditBoot.Location = new System.Drawing.Point(304, 323);
            this.btn_EditBoot.Name = "btn_EditBoot";
            this.btn_EditBoot.Size = new System.Drawing.Size(75, 23);
            this.btn_EditBoot.TabIndex = 10;
            this.btn_EditBoot.Text = "Wijzig";
            this.btn_EditBoot.UseVisualStyleBackColor = true;
            // 
            // btn_DeleteBoot
            // 
            this.btn_DeleteBoot.Location = new System.Drawing.Point(304, 352);
            this.btn_DeleteBoot.Name = "btn_DeleteBoot";
            this.btn_DeleteBoot.Size = new System.Drawing.Size(75, 23);
            this.btn_DeleteBoot.TabIndex = 11;
            this.btn_DeleteBoot.Text = "Verwijder";
            this.btn_DeleteBoot.UseVisualStyleBackColor = true;
            // 
            // btn_EditArtikel
            // 
            this.btn_EditArtikel.Location = new System.Drawing.Point(304, 323);
            this.btn_EditArtikel.Name = "btn_EditArtikel";
            this.btn_EditArtikel.Size = new System.Drawing.Size(75, 23);
            this.btn_EditArtikel.TabIndex = 2;
            this.btn_EditArtikel.Text = "Wijzig";
            this.btn_EditArtikel.UseVisualStyleBackColor = true;
            // 
            // btn_DeleteArtikel
            // 
            this.btn_DeleteArtikel.Location = new System.Drawing.Point(304, 352);
            this.btn_DeleteArtikel.Name = "btn_DeleteArtikel";
            this.btn_DeleteArtikel.Size = new System.Drawing.Size(75, 23);
            this.btn_DeleteArtikel.TabIndex = 3;
            this.btn_DeleteArtikel.Text = "Verwijder";
            this.btn_DeleteArtikel.UseVisualStyleBackColor = true;
            // 
            // lbl_Prijs
            // 
            this.lbl_Prijs.AutoSize = true;
            this.lbl_Prijs.Location = new System.Drawing.Point(202, 128);
            this.lbl_Prijs.Name = "lbl_Prijs";
            this.lbl_Prijs.Size = new System.Drawing.Size(29, 13);
            this.lbl_Prijs.TabIndex = 12;
            this.lbl_Prijs.Text = "Prijs:";
            // 
            // lbl_ShowPrijs
            // 
            this.lbl_ShowPrijs.AutoSize = true;
            this.lbl_ShowPrijs.Location = new System.Drawing.Point(270, 128);
            this.lbl_ShowPrijs.Name = "lbl_ShowPrijs";
            this.lbl_ShowPrijs.Size = new System.Drawing.Size(12, 13);
            this.lbl_ShowPrijs.TabIndex = 13;
            this.lbl_ShowPrijs.Text = "x";
            // 
            // lbl_ShowPrijsArt
            // 
            this.lbl_ShowPrijsArt.AutoSize = true;
            this.lbl_ShowPrijsArt.Location = new System.Drawing.Point(270, 62);
            this.lbl_ShowPrijsArt.Name = "lbl_ShowPrijsArt";
            this.lbl_ShowPrijsArt.Size = new System.Drawing.Size(12, 13);
            this.lbl_ShowPrijsArt.TabIndex = 10;
            this.lbl_ShowPrijsArt.Text = "x";
            // 
            // lbl_ShowNaam
            // 
            this.lbl_ShowNaam.AutoSize = true;
            this.lbl_ShowNaam.Location = new System.Drawing.Point(270, 40);
            this.lbl_ShowNaam.Name = "lbl_ShowNaam";
            this.lbl_ShowNaam.Size = new System.Drawing.Size(12, 13);
            this.lbl_ShowNaam.TabIndex = 9;
            this.lbl_ShowNaam.Text = "x";
            // 
            // lbl_ArtPrijs
            // 
            this.lbl_ArtPrijs.AutoSize = true;
            this.lbl_ArtPrijs.Location = new System.Drawing.Point(202, 62);
            this.lbl_ArtPrijs.Name = "lbl_ArtPrijs";
            this.lbl_ArtPrijs.Size = new System.Drawing.Size(29, 13);
            this.lbl_ArtPrijs.TabIndex = 8;
            this.lbl_ArtPrijs.Text = "Prijs:";
            // 
            // lbl_Naam
            // 
            this.lbl_Naam.AutoSize = true;
            this.lbl_Naam.Location = new System.Drawing.Point(202, 40);
            this.lbl_Naam.Name = "lbl_Naam";
            this.lbl_Naam.Size = new System.Drawing.Size(38, 13);
            this.lbl_Naam.TabIndex = 7;
            this.lbl_Naam.Text = "Naam:";
            // 
            // gb_Wateren
            // 
            this.gb_Wateren.Controls.Add(this.lbl_ShowPrijsVW);
            this.gb_Wateren.Controls.Add(this.lbl_NaamVW);
            this.gb_Wateren.Controls.Add(this.lbl_PrijsVW);
            this.gb_Wateren.Controls.Add(this.lbl_NaamVaarwater);
            this.gb_Wateren.Controls.Add(this.btn_AddVW);
            this.gb_Wateren.Controls.Add(this.lb_Vaarwateren);
            this.gb_Wateren.Location = new System.Drawing.Point(12, 403);
            this.gb_Wateren.Name = "gb_Wateren";
            this.gb_Wateren.Size = new System.Drawing.Size(385, 385);
            this.gb_Wateren.TabIndex = 4;
            this.gb_Wateren.TabStop = false;
            this.gb_Wateren.Text = "Vaarwateren";
            // 
            // lbl_ShowPrijsVW
            // 
            this.lbl_ShowPrijsVW.AutoSize = true;
            this.lbl_ShowPrijsVW.Location = new System.Drawing.Point(270, 62);
            this.lbl_ShowPrijsVW.Name = "lbl_ShowPrijsVW";
            this.lbl_ShowPrijsVW.Size = new System.Drawing.Size(12, 13);
            this.lbl_ShowPrijsVW.TabIndex = 10;
            this.lbl_ShowPrijsVW.Text = "x";
            // 
            // lbl_NaamVW
            // 
            this.lbl_NaamVW.AutoSize = true;
            this.lbl_NaamVW.Location = new System.Drawing.Point(270, 40);
            this.lbl_NaamVW.Name = "lbl_NaamVW";
            this.lbl_NaamVW.Size = new System.Drawing.Size(12, 13);
            this.lbl_NaamVW.TabIndex = 9;
            this.lbl_NaamVW.Text = "x";
            // 
            // lbl_PrijsVW
            // 
            this.lbl_PrijsVW.AutoSize = true;
            this.lbl_PrijsVW.Location = new System.Drawing.Point(202, 62);
            this.lbl_PrijsVW.Name = "lbl_PrijsVW";
            this.lbl_PrijsVW.Size = new System.Drawing.Size(29, 13);
            this.lbl_PrijsVW.TabIndex = 8;
            this.lbl_PrijsVW.Text = "Prijs:";
            // 
            // lbl_NaamVaarwater
            // 
            this.lbl_NaamVaarwater.AutoSize = true;
            this.lbl_NaamVaarwater.Location = new System.Drawing.Point(202, 40);
            this.lbl_NaamVaarwater.Name = "lbl_NaamVaarwater";
            this.lbl_NaamVaarwater.Size = new System.Drawing.Size(38, 13);
            this.lbl_NaamVaarwater.TabIndex = 7;
            this.lbl_NaamVaarwater.Text = "Naam:";
            // 
            // btn_AddVW
            // 
            this.btn_AddVW.Location = new System.Drawing.Point(304, 352);
            this.btn_AddVW.Name = "btn_AddVW";
            this.btn_AddVW.Size = new System.Drawing.Size(75, 23);
            this.btn_AddVW.TabIndex = 1;
            this.btn_AddVW.Text = "Toevoegen";
            this.btn_AddVW.UseVisualStyleBackColor = true;
            // 
            // lb_Vaarwateren
            // 
            this.lb_Vaarwateren.FormattingEnabled = true;
            this.lb_Vaarwateren.Location = new System.Drawing.Point(7, 20);
            this.lb_Vaarwateren.Name = "lb_Vaarwateren";
            this.lb_Vaarwateren.Size = new System.Drawing.Size(189, 355);
            this.lb_Vaarwateren.TabIndex = 0;
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(715, 760);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(75, 23);
            this.btn_Back.TabIndex = 5;
            this.btn_Back.Text = "Terug";
            this.btn_Back.UseVisualStyleBackColor = true;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 795);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.gb_Wateren);
            this.Controls.Add(this.gb_Artikelen);
            this.Controls.Add(this.gb_Boten);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.gb_Boten.ResumeLayout(false);
            this.gb_Boten.PerformLayout();
            this.gb_Artikelen.ResumeLayout(false);
            this.gb_Artikelen.PerformLayout();
            this.gb_Wateren.ResumeLayout(false);
            this.gb_Wateren.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Boten;
        private System.Windows.Forms.Button btn_AddBoot;
        private System.Windows.Forms.Label lbl_ShowBoottype;
        private System.Windows.Forms.Label lbl_ShowBootAandrijving;
        private System.Windows.Forms.Label lbl_ShowBootSoort;
        private System.Windows.Forms.Label lbl_ShowBootNaam;
        private System.Windows.Forms.Label lbl_boottype;
        private System.Windows.Forms.Label lbl_bootaandrijving;
        private System.Windows.Forms.Label lbl_Bootsoort;
        private System.Windows.Forms.Label lbl_Bootnaam;
        private System.Windows.Forms.ListBox lb_Boten;
        private System.Windows.Forms.Label lbl_ShowPrijs;
        private System.Windows.Forms.Label lbl_Prijs;
        private System.Windows.Forms.Button btn_DeleteBoot;
        private System.Windows.Forms.Button btn_EditBoot;
        private System.Windows.Forms.GroupBox gb_Artikelen;
        private System.Windows.Forms.Label lbl_ShowPrijsArt;
        private System.Windows.Forms.Label lbl_ShowNaam;
        private System.Windows.Forms.Label lbl_ArtPrijs;
        private System.Windows.Forms.Label lbl_Naam;
        private System.Windows.Forms.Button btn_DeleteArtikel;
        private System.Windows.Forms.Button btn_EditArtikel;
        private System.Windows.Forms.Button btn_AddArtikel;
        private System.Windows.Forms.ListBox lb_Artikelen;
        private System.Windows.Forms.GroupBox gb_Wateren;
        private System.Windows.Forms.Label lbl_ShowPrijsVW;
        private System.Windows.Forms.Label lbl_NaamVW;
        private System.Windows.Forms.Label lbl_PrijsVW;
        private System.Windows.Forms.Label lbl_NaamVaarwater;
        private System.Windows.Forms.Button btn_AddVW;
        private System.Windows.Forms.ListBox lb_Vaarwateren;
        private System.Windows.Forms.Button btn_Back;
    }
}