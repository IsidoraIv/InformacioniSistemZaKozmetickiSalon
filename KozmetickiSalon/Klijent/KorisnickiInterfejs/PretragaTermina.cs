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
    public partial class PretragaTermina : Form
    {
        public PretragaTermina()
        {
            InitializeComponent();
        }

        private void dtpDatum_ValueChanged(object sender, EventArgs e)
        {
            KontrolerKI.PretraziTermine(dtpDatum, groupBox1, dataGridView1,cmbKorisnik);
        }

        private void PretragaTermina_Load(object sender, EventArgs e)
        {
            KontrolerKI.VratiSveTermine(groupBox1, dataGridView1);
                KontrolerKI.PopuniComboKorisnik(cmbKorisnik);

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (KontrolerKI.PrikaziTermin(dataGridView1)) new DetaljiTermina().ShowDialog();          
            dtpDatum_ValueChanged(sender, e);

        }

        private void cmbKorisnik_SelectedIndexChanged(object sender, EventArgs e)
        {
            KontrolerKI.PretraziTermine(dtpDatum, groupBox1, dataGridView1, cmbKorisnik);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new UnosTermina().ShowDialog();
            this.Show();
            KontrolerKI.PretraziTermine(dtpDatum, groupBox1, dataGridView1, cmbKorisnik);
        }
    }
}
