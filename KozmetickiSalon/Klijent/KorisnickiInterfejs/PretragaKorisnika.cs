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
    public partial class PretragaKorisnika : Form
    {
        public PretragaKorisnika()
        {
            InitializeComponent();
        }

        private void PretragaKorisnika_Load(object sender, EventArgs e)
        {
            KontrolerKI.PretraziKorisnike(txtFilter, dataGridView1);
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtFilter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                KontrolerKI.PretraziKorisnike(txtFilter, dataGridView1);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (KontrolerKI.PrikaziKorisnika(dataGridView1))
            {
                new DetaljiKorisnika().ShowDialog();
                KontrolerKI.PretraziKorisnike(txtFilter,dataGridView1);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new UnosKorisnika().ShowDialog();
            this.Show();
            KontrolerKI.PretraziKorisnike(txtFilter, dataGridView1);
        }
    }
}
