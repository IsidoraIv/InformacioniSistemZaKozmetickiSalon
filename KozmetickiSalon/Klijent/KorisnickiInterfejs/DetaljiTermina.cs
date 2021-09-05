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
    public partial class DetaljiTermina : Form
    {
        public DetaljiTermina()
        {
            InitializeComponent();
        }

        private void DetaljiTermina_Load(object sender, EventArgs e)
        {
            KontrolerKI.PopuniDetaljeTermina(txtKorisnik,txtDatumT,txtDatumZ,dataGridView1);
        }
    }
}
