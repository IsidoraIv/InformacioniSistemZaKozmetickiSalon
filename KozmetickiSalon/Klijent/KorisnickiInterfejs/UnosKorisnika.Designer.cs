namespace Klijent.KorisnickiInterfejs
{
    partial class UnosKorisnika
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnosKorisnika));
            this.gbKorisnik = new System.Windows.Forms.GroupBox();
            this.txtkontakt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnZapamti = new System.Windows.Forms.Button();
            this.btnKreiraj = new System.Windows.Forms.Button();
            this.txtSifra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.gbKorisnik.Enabled = false;
            this.gbKorisnik.Location = new System.Drawing.Point(22, 53);
            this.gbKorisnik.Name = "gbKorisnik";
            this.gbKorisnik.Size = new System.Drawing.Size(311, 159);
            this.gbKorisnik.TabIndex = 7;
            this.gbKorisnik.TabStop = false;
            this.gbKorisnik.Text = "Unos podataka o korisniku";
            // 
            // txtkontakt
            // 
            this.txtkontakt.Location = new System.Drawing.Point(89, 64);
            this.txtkontakt.Name = "txtkontakt";
            this.txtkontakt.Size = new System.Drawing.Size(200, 20);
            this.txtkontakt.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kontakt:";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(89, 38);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(200, 20);
            this.txtIme.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ime i prezime:";
            // 
            // btnZapamti
            // 
            this.btnZapamti.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnZapamti.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnZapamti.BackgroundImage")));
            this.btnZapamti.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnZapamti.Location = new System.Drawing.Point(22, 102);
            this.btnZapamti.Name = "btnZapamti";
            this.btnZapamti.Size = new System.Drawing.Size(267, 40);
            this.btnZapamti.TabIndex = 4;
            this.btnZapamti.UseVisualStyleBackColor = false;
            this.btnZapamti.Click += new System.EventHandler(this.btnZapamti_Click);
            // 
            // btnKreiraj
            // 
            this.btnKreiraj.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnKreiraj.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKreiraj.BackgroundImage")));
            this.btnKreiraj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnKreiraj.Location = new System.Drawing.Point(232, 2);
            this.btnKreiraj.Name = "btnKreiraj";
            this.btnKreiraj.Size = new System.Drawing.Size(36, 36);
            this.btnKreiraj.TabIndex = 6;
            this.btnKreiraj.UseVisualStyleBackColor = false;
            this.btnKreiraj.Click += new System.EventHandler(this.btnKreiraj_Click);
            // 
            // txtSifra
            // 
            this.txtSifra.Location = new System.Drawing.Point(111, 12);
            this.txtSifra.Name = "txtSifra";
            this.txtSifra.ReadOnly = true;
            this.txtSifra.Size = new System.Drawing.Size(70, 20);
            this.txtSifra.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sifra korisnika:";
            // 
            // UnosKorisnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(357, 226);
            this.Controls.Add(this.gbKorisnik);
            this.Controls.Add(this.btnKreiraj);
            this.Controls.Add(this.txtSifra);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UnosKorisnika";
            this.Text = "Unos korisnika";
            this.Load += new System.EventHandler(this.UnosKorisnika_Load);
            this.gbKorisnik.ResumeLayout(false);
            this.gbKorisnik.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbKorisnik;
        private System.Windows.Forms.TextBox txtkontakt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnZapamti;
        private System.Windows.Forms.Button btnKreiraj;
        private System.Windows.Forms.TextBox txtSifra;
        private System.Windows.Forms.Label label1;
    }
}