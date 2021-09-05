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
    public partial class DetaljiUsluge : Form
    {
        public DetaljiUsluge()
        {
            InitializeComponent();
        }

        private void DetaljiUsluge_Load(object sender, EventArgs e)
        {
            KontrolerKI.PopuniPoljaUsluga(txtNaziv, txtOpis, txtCena,txtKat,txtTip,dataGridView1);
            
        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (KontrolerKI.ObrisiUslugu()) this.Close();
        }
    }
}
