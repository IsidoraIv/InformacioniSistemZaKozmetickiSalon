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
    public partial class UnosKorisnika : Form
    {
        public UnosKorisnika()
        {
            InitializeComponent();
        }

        private void btnKreiraj_Click(object sender, EventArgs e)
        {
            KontrolerKI.KreirajKorisnika(txtSifra, gbKorisnik, btnKreiraj);
        }

        private void btnZapamti_Click(object sender, EventArgs e)
        {
            if (KontrolerKI.ZapamtiKorisnika(txtIme,txtkontakt)) this.Close();
        }

        private void UnosKorisnika_Load(object sender, EventArgs e)
        {

        }
    }
}
