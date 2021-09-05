using Domen;
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
    public partial class Login : Form
    {
       
        public Login()
        {
            InitializeComponent();
        }

        private void FormaKlijent_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (KontrolerKI.PoveziSeNaServer())
            {
                if (KontrolerKI.Login(txtKorSifra))
                {
                    this.Hide();
                    new PocetnaForma().ShowDialog();
                    this.Show();
                }
            }
            else
            {
                MessageBox.Show("NEUSPELO POVEZIVANJE NA SERVER!");
            }
        }
    }
}
