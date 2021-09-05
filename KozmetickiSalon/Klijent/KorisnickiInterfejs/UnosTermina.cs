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
    public partial class UnosTermina : Form
    {
        public UnosTermina()
        {
            InitializeComponent();
        }

     
        private void button3_Click(object sender, EventArgs e)
        {
            KontrolerKI.DodajStavku(cmbUsluga);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            KontrolerKI.ObrisiStavku(dataGridView1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (KontrolerKI.ZapamtiTermin(dtpDatum,cmbKorisnik)) this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void UnosTermina_Load(object sender, EventArgs e)
        {
            if (KontrolerKI.KreirajTermin(dataGridView1))
            {
                KontrolerKI.PopuniComboUsluga(cmbUsluga);
                KontrolerKI.PopuniComboKorisnik(cmbKorisnik);
              
            }
        }
    }
}
