using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klijent.KorisnickiInterfejs
{
    public partial class PocetnaForma : Form
    {
        public PocetnaForma()
        {
            InitializeComponent();
        }

        private void PocetnaForma_Load(object sender, EventArgs e)
        {
           this.Text= KontrolerKI.PrikaziUlogovanogZaposlenog();
        }

        private void PocetnaForma_FormClosed(object sender, FormClosedEventArgs e)
        {
            KontrolerKI.Kraj();
        }

      
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new PretragaKorisnika().ShowDialog();
            this.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new PretragaUsluga().ShowDialog();
            this.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new PretragaTermina().ShowDialog();
            this.Show();
        }
    }
}
