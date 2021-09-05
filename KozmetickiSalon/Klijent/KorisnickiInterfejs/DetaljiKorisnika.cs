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
    public partial class DetaljiKorisnika : Form
    {
        public DetaljiKorisnika()
        {
            InitializeComponent();
        }

        private void DetaljiKorisnika_Load(object sender, EventArgs e)
        {
            KontrolerKI.PopuniPoljaKorisnik(txtIme, txtkontakt);
        }

        private void btnZapamti_Click(object sender, EventArgs e)
        {
            if (KontrolerKI.ZapamtiKorisnika(txtIme, txtkontakt)) this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (KontrolerKI.ObrisiKorisnika()) this.Close();
        }
    }
}
