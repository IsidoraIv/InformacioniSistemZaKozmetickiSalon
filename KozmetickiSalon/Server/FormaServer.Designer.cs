namespace Server
{
    partial class FormaServer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormaServer));
            this.btnPokreni = new System.Windows.Forms.Button();
            this.btnZaustavi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPokreni
            // 
            this.btnPokreni.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnPokreni.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPokreni.BackgroundImage")));
            this.btnPokreni.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPokreni.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPokreni.Location = new System.Drawing.Point(93, 24);
            this.btnPokreni.Name = "btnPokreni";
            this.btnPokreni.Size = new System.Drawing.Size(144, 140);
            this.btnPokreni.TabIndex = 1;
            this.btnPokreni.UseVisualStyleBackColor = false;
            this.btnPokreni.Click += new System.EventHandler(this.btnPokreni_Click);
            // 
            // btnZaustavi
            // 
            this.btnZaustavi.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnZaustavi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnZaustavi.BackgroundImage")));
            this.btnZaustavi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnZaustavi.Enabled = false;
            this.btnZaustavi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZaustavi.Location = new System.Drawing.Point(361, 24);
            this.btnZaustavi.Name = "btnZaustavi";
            this.btnZaustavi.Size = new System.Drawing.Size(140, 140);
            this.btnZaustavi.TabIndex = 2;
            this.btnZaustavi.UseVisualStyleBackColor = false;
            this.btnZaustavi.Click += new System.EventHandler(this.btnZaustavi_Click);
            // 
            // FormaServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(608, 191);
            this.Controls.Add(this.btnZaustavi);
            this.Controls.Add(this.btnPokreni);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormaServer";
            this.Text = "Server ";
            this.Load += new System.EventHandler(this.FormaServer_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnPokreni;
        private System.Windows.Forms.Button btnZaustavi;
    }
}

