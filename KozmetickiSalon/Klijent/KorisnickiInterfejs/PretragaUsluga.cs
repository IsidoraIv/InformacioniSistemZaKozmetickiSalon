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
    public partial class PretragaUsluga : Form
    {
        public PretragaUsluga()
        {
            InitializeComponent();
        }

        private void PretragaUsluga_Load(object sender, EventArgs e)
        {
            KontrolerKI.PretraziUsluge(txtNaziv, dataGridView1);
        }

        private void txtNaziv_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                KontrolerKI.PretraziUsluge(txtNaziv, dataGridView1);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (KontrolerKI.PrikaziUslugu(dataGridView1))
            {
                this.Hide();
                new DetaljiUsluge().ShowDialog();
                this.Show();
                             
                KontrolerKI.PretraziUsluge(txtNaziv, dataGridView1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new UnosUsluge().ShowDialog();
            this.Show();
            KontrolerKI.PretraziUsluge(txtNaziv, dataGridView1);
        }
    }
}
