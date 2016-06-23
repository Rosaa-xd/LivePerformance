namespace Live_Performance.Forms
{
    partial class AddVaarwaterForm
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
            this.btn_AddVaarwater = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_vwNaam = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_AddVaarwater
            // 
            this.btn_AddVaarwater.Location = new System.Drawing.Point(107, 50);
            this.btn_AddVaarwater.Name = "btn_AddVaarwater";
            this.btn_AddVaarwater.Size = new System.Drawing.Size(75, 23);
            this.btn_AddVaarwater.TabIndex = 0;
            this.btn_AddVaarwater.Text = "OK";
            this.btn_AddVaarwater.UseVisualStyleBackColor = true;
            this.btn_AddVaarwater.Click += new System.EventHandler(this.btn_AddVaarwater_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Naam:";
            // 
            // tb_vwNaam
            // 
            this.tb_vwNaam.Location = new System.Drawing.Point(74, 24);
            this.tb_vwNaam.Name = "tb_vwNaam";
            this.tb_vwNaam.Size = new System.Drawing.Size(164, 20);
            this.tb_vwNaam.TabIndex = 2;
            // 
            // AddVaarwaterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 92);
            this.Controls.Add(this.tb_vwNaam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_AddVaarwater);
            this.Name = "AddVaarwaterForm";
            this.Text = "AddVaarwater";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_AddVaarwater;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_vwNaam;
    }
}