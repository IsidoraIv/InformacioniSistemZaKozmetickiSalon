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
    public partial class UnosUsluge : Form
    {
        public UnosUsluge()
        {
            InitializeComponent();
        }

      

        private void btnKreiraj_Click(object sender, EventArgs e)
        {
            if (KontrolerKI.KreirajUslugu(txtSifra, btnKreiraj, gbUsluga, dataGridView1))
            {
                KontrolerKI.PopuniComboTip(cmbTip);              
                KontrolerKI.PopuniComboZaposleni(cmbZaposleni);              
                KontrolerKI.PopuniComboKategorija(cmbKat);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (KontrolerKI.ZapamtiUslugu(txtNaziv, txtOpis, cmbTip,cmbKat,txtCena)) this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            KontrolerKI.DodajZaduzenje(cmbZaposleni,txtBrUsluga);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            KontrolerKI.ObrisiZaduzenje(dataGridView1);
        }
    }
}
