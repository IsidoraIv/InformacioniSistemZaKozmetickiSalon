namespace Klijent.KorisnickiInterfejs
{
    partial class DetaljiKorisnika
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetaljiKorisnika));
            this.gbKorisnik = new System.Windows.Forms.GroupBox();
            this.btnZapamti = new System.Windows.Forms.Button();
            this.txtkontakt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbKorisnik.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbKorisnik
            // 
            this.gbKorisnik.Controls.Add(this.txtkontakt);
            this.gbKorisnik.Controls.Add(this.label3);
            this.gbKorisnik.Controls.Add(this.txtIme);
            this.gbKorisnik.Controls.Add(this.label2);
            this.gbKorisnik.Controls.Add(this.btnZapamti);
            this.gbKorisnik.Location = new System.Drawing.Point(12, 12);
            this.gbKorisnik.Name = "gbKorisnik";
            this.gbKorisnik.Size = new System.Drawing.Size(311, 159);
            this.gbKorisnik.TabIndex = 8;
            this.gbKorisnik.TabStop = false;
            this.gbKorisnik.Text = "Unos podataka o korisniku";
            // 
            // btnZapamti
            // 
            this.btnZapamti.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnZapamti.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnZapamti.BackgroundImage")));
            this.btnZapamti.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnZapamti.Location = new System.Drawing.Point(22, 93);
            this.btnZapamti.Name = "btnZapamti";
            this.btnZapamti.Size = new System.Drawing.Size(267, 40);
            this.btnZapamti.TabIndex = 4;
            this.btnZapamti.UseVisualStyleBackColor = false;
            this.btnZapamti.Click += new System.EventHandler(this.btnZapamti_Click);
            // 
            // txtkontakt
            // 
            this.txtkontakt.Location = new System.Drawing.Point(89, 56);
            this.txtkontakt.Name = "txtkontakt";
            this.txtkontakt.Size = new System.Drawing.Size(200, 20);
            this.txtkontakt.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Kontakt:";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(89, 30);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(200, 20);
            this.txtIme.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Ime i prezime:";
            // 
            // DetaljiKorisnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(338, 182);
            this.Controls.Add(this.gbKorisnik);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DetaljiKorisnika";
            this.Text = "DetaljiKorisnika";
            this.Load += new System.EventHandler(this.DetaljiKorisnika_Load);
            this.gbKorisnik.ResumeLayout(false);
            this.gbKorisnik.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbKorisnik;
        private System.Windows.Forms.Button btnZapamti;
        private System.Windows.Forms.TextBox txtkontakt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label label2;
    }
}