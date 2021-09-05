using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klijent
{
    public class KontrolerKI
    {
        public static Komunikacija komunikacija;
        public static Zaposleni zaposleni;
        public static Usluga usluga;
        public static Korisnik korisnik;
        public static Termin termin;

        public static bool PoveziSeNaServer()
        {
            if (komunikacija == null) komunikacija = new Komunikacija();
            return komunikacija.poveziSeNaServer();           
        }

        internal static void PopuniDetaljeTermina(TextBox txtKorisnik, TextBox txtDatumT, TextBox txtDatumZ, DataGridView dataGridView1)
        {
            txtKorisnik.Text = termin.Korisnik.ToString();
            txtDatumT.Text = termin.DatumTermina.ToString("dd.MM.yyyy");
            txtDatumZ.Text = termin.DatumZakazivanja.ToString("dd.MM.yyyy");
            dataGridView1.DataSource = termin.StavkeTermina;
        }

        internal static bool ObrisiUslugu()
        {
            object rez = komunikacija.ObrisiUslugu(usluga);

            if (rez == null)
            {
                MessageBox.Show("Sistem ne moze da obrise uslugu!");
                return false;
            }
            MessageBox.Show("Sistem je obrisao uslugu!");
            return true;
        }

        internal static void PopuniPoljaKorisnik(TextBox txtIme, TextBox txtKontakt)
        {
            txtIme.Text = korisnik.ImePrezime;
            txtKontakt.Text = korisnik.Kontakt;
        }

        internal static void ObrisiZaduzenje(DataGridView dataGridView1)
        {
            try
            {
                Zaduzenje z = dataGridView1.CurrentRow.DataBoundItem as Zaduzenje;
                usluga.ListaZaduzenja.Remove(z);
            }
            catch (Exception)
            {

                
            }
        }

        internal static void DodajZaduzenje(ComboBox cmbZaposleni, TextBox txtBrUsluga)
        {
            Zaduzenje z = new Zaduzenje();
            z.Usluga = usluga;
            z.Zaposleni = cmbZaposleni.SelectedItem as Zaposleni;
            if (z.Zaposleni == null) 
            {
                MessageBox.Show("Niste odabrali zaposlenog!");
                return ;
            }

            try
            {
                z.BrUsluga = Convert.ToInt32(txtBrUsluga.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Niste ispravno uneli broj usluga!");
                return;
            }

            usluga.ListaZaduzenja.Add(z);
        }

        internal static void PretraziKorisnike(TextBox txtFilter, DataGridView dataGridView1)
        {
            korisnik = new Korisnik();        
            korisnik.USLOV = " ImePrezime like '%"+txtFilter.Text+"%' ";
            List<Korisnik> lista = (List<Korisnik>)komunikacija.PretraziKorisnike(korisnik);
            dataGridView1.DataSource = lista;
            if (lista == null || lista.Count == 0)
            {
                MessageBox.Show("Nema korisnika za uneti kriterijum!");
                dataGridView1.Enabled = false;
            }
            else dataGridView1.Enabled = true;
        }
               

        internal static bool PrikaziKorisnika(DataGridView dataGridView1)
        {
            try
            {
                korisnik = dataGridView1.CurrentRow.DataBoundItem as Korisnik;
                korisnik = (Korisnik)komunikacija.PrikaziKorisnika(korisnik);
                if (korisnik == null)
                {
                    MessageBox.Show("Sistem ne moze da ucita korisnika!");
                    return false;
                }
                else
                {
                    MessageBox.Show("Sistem je ucitao korisnika!");
                    return true;
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Niste odabrali korisnika!");
                return false;
            }
        }

        internal static void VratiSveTermine(GroupBox groupBox1, DataGridView dataGridView1)
        {
            termin = new Termin();
            termin.Uslov = " cast (Datum as date) > cast ('1900-01-01' as date) ";
            List<Termin> lista = (List<Termin>)komunikacija.PretraziTermine(termin);
            dataGridView1.DataSource = lista;
            if (lista == null || lista.Count == 0)
            {
                //MessageBox.Show("Nema termina!");
                dataGridView1.Enabled = false;
            }
            else dataGridView1.Enabled = true;
        }

      

        internal static bool PrikaziTermin(DataGridView dataGridView1)
        {
            try
            {
                termin = dataGridView1.CurrentRow.DataBoundItem as Termin;
                termin = (Termin)komunikacija.PrikaziTermin(termin);
                if (termin == null)
                {
                    MessageBox.Show("Sistem ne moze da ucita termin!");
                    return false;
                }
                else
                {
                    MessageBox.Show("Sistem je ucitao termin!");
                    return true;
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Niste odabrali racterminun!");
                return false;
            }
        }

        internal static void PretraziTermine(DateTimePicker dtpDatum, GroupBox groupBox1, DataGridView dataGridView1, ComboBox cmbKorisnik)
        {
            termin = new Termin();
            DateTime datum = dtpDatum.Value;
            termin.Uslov = " day(DatumTermina)=" + datum.Day + " and month(DatumTermina)=" + datum.Month + " and year(DatumTermina)=" + datum.Year + "";
            termin.Korisnik = cmbKorisnik.SelectedItem as Korisnik;
            if (termin.Korisnik != null) termin.Uslov += " and KorisnikID=" + termin.Korisnik.Id;
            List<Termin> lista = (List<Termin>)komunikacija.PretraziTermine(termin);
            dataGridView1.DataSource = lista;
            if (lista == null || lista.Count == 0)
            {
                MessageBox.Show("Nema termina za izabrani datum!");
                dataGridView1.Enabled = false;
            }
            else dataGridView1.Enabled = true;
        }

        internal static void PopuniComboUsluga(ComboBox cmb)
        {
            cmb.Items.Clear();
            List<Usluga> lista = (List<Usluga>)komunikacija.VratiSveUsluge();
            foreach (var a in lista)
            {
                cmb.Items.Add(a);
            }

            cmb.Text = "Izaberite uslugu!";
        }

        internal static void DodajStavku(ComboBox cmbUsluga)
        {
            StavkaTermina st = new StavkaTermina();           
            st.Rbr = termin.StavkeTermina.Count + 1;
            st.Usluga = cmbUsluga.SelectedItem as Usluga;
            if (st.Usluga == null)
            {
                MessageBox.Show("Niste odabrali uslugu!");
                return;
            }

          

            foreach (StavkaTermina s in termin.StavkeTermina)
            {
                if (s.Usluga.Equals(st.Usluga))
                {
                    MessageBox.Show("Usluga je vec dodata u termin!");
                    return;
                }
            }

            termin.StavkeTermina.Add(st);
          
            PopuniComboUsluga(cmbUsluga);
        }

        internal static bool ZapamtiTermin(DateTimePicker dtpDatum, ComboBox cmbKorisnik)
        {
            termin.Zaposleni = zaposleni;
            try
            {
                termin.DatumTermina = dtpDatum.Value;
            }
            catch (Exception)
            {

                MessageBox.Show("Datum i vreme nisu ispravno uneti!");
                return false;
            }

            termin.DatumZakazivanja = DateTime.Now;

            if (termin.DatumTermina.Date < termin.DatumZakazivanja.Date) 
            {
                MessageBox.Show("Termin mora biti zakazan u buducnosti!");
                return false;
            }

            termin.Korisnik = cmbKorisnik.SelectedItem as Korisnik;

            if (termin.Korisnik == null)
            {
                MessageBox.Show("Niste odabrali korisnika!");
                return false;
            }


            object rez = komunikacija.zapamtiTermin(termin);

            if (rez == null)
            {
                MessageBox.Show("Sistem ne moze da zapamti termin!");
                return false;
            }
            MessageBox.Show("Sistem je zapamtio termin!");
            return true;

        }

        internal static void ObrisiStavku(DataGridView dataGridView1)
        {
            try
            {
                StavkaTermina s = dataGridView1.CurrentRow.DataBoundItem as StavkaTermina;
                termin.StavkeTermina.Remove(s);
              
                int i = 1;
                foreach (StavkaTermina sr in termin.StavkeTermina)
                {
                    sr.Rbr = i;
                    i++;
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Niste odabrali stavku!");
            }
        }

        internal static void PrikaziRadnika(TextBox txtRadnik)
        {
            txtRadnik.Text = zaposleni.ToString();
        }

        internal static bool KreirajTermin(DataGridView dataGridView1)
        {
            try
            {
                termin = new Termin();


                dataGridView1.DataSource = termin.StavkeTermina;
                return true;
            }
            catch (Exception)
            {

                return false;
            }
            
        }

        internal static void PopuniPoljaUsluga(TextBox txtNaziv, TextBox txtOpis, TextBox txtCena, TextBox txtKat, TextBox txtTip, DataGridView dgvZaduzenja)
        {
            
            txtNaziv.Text = usluga.Naziv;
            txtOpis.Text = usluga.Opis;           
            txtTip.Text = usluga.Tip.ToString();
            txtCena.Text = usluga.Cena.ToString("N02");
            txtKat.Text = usluga.Kategorija.ToString();
            dgvZaduzenja.DataSource = usluga.ListaZaduzenja;
        }

      

        internal static void PretraziUsluge(TextBox txtNaziv, DataGridView dataGridView1)
        {
            usluga = new Usluga();
            usluga.Uslov = " Naziv like '%"+txtNaziv.Text+"%' ";
            List<Usluga> lista = (List<Usluga>)komunikacija.PretraziUsluge(usluga);

            if (lista == null)
            {
                MessageBox.Show("Sistem ne moze da pronadje usluge!");
            }

            dataGridView1.DataSource = lista;

            if (lista.Count == 0)
            {
                MessageBox.Show("Nema usluga za uneti naziv!");
            }

           //  MessageBox.Show("Sistem je pronasao usluge!");
        }

        internal static bool PrikaziUslugu(DataGridView dataGridView1)
        {
            try
            {
                usluga = dataGridView1.CurrentRow.DataBoundItem as Usluga;
                usluga = (Usluga)komunikacija.PrikaziUslugu(usluga);
                if (usluga == null)
                {
                    MessageBox.Show("Sistem ne moze da ucita podatke o usluzi!");
                    return false;
                }
                else
                {
                    MessageBox.Show("Sistem je ucitao podatke o usluzi!");
                    return true;
                }
               
            }
            catch (Exception)
            {

                MessageBox.Show("Niste odabrali uslugu!");
                return false;
            }
        }

        internal static bool KreirajUslugu(TextBox txtSifra, Button btnKreiraj, GroupBox gbUsluga, DataGridView dgvZaduzenja)
        {
            usluga = (Usluga)komunikacija.KreirajUslugu();

            if (usluga == null)
            {
                MessageBox.Show("Sistem ne moze da kreira uslugu!");
                return false;
            }
            else
            {
                MessageBox.Show("Sistem je uspesno kreirao uslugu!");
                txtSifra.Text = usluga.Id.ToString();
                btnKreiraj.Enabled = false;
                gbUsluga.Enabled = true;
                dgvZaduzenja.DataSource = usluga.ListaZaduzenja;
                return true;
            }
        }

        internal static bool ZapamtiUslugu(TextBox txtNaziv, TextBox txtOpis, ComboBox cmbTip, ComboBox cmbKat, TextBox txtCena)
        {
            usluga.Naziv = txtNaziv.Text;

            if (usluga.Naziv == "")
            {
                MessageBox.Show("Naziv je obavezan!");
                return false;
            }
           
            usluga.Opis = txtOpis.Text;

            usluga.Tip = cmbTip.SelectedItem as TipUsluge;

            if (usluga.Tip == null)
            {
                MessageBox.Show("Niste odabrali tip usluge!");
                return false;
            }

            usluga.Kategorija = cmbKat.SelectedItem as Kategorija;

            if (usluga.Kategorija == null)
            {
                MessageBox.Show("Niste odabrali kategoriju!");
                return false;
            }

            try
            {
                usluga.Cena = Convert.ToInt32(txtCena.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Niste ispravno uneli cenu!");
                return false;
            }

            if (usluga.Cena < 0) 
            {
                MessageBox.Show("Niste ispravno uneli cenu!");
                return false;
            }

            object o = komunikacija.ZapamtiUslugu(usluga);
            if (o == null)
            {
                MessageBox.Show("Sistem ne moze da zapamti uslugu!");
                return false;
            }
            else
            {
                MessageBox.Show("Sistem je uspesno zapamtio uslugu!");
                return true;
            }
        }

        internal static bool ObrisiKorisnika()
        {
            object o = komunikacija.ObrisiKorisnika(korisnik);
            if (o == null)
            {
                MessageBox.Show("Sistem ne moze da obrise korisnika!");
                return false;
            }
            else
            {
                MessageBox.Show("Sistem je uspesno obrisao korisnika!");
                return true;
            }
        }

        internal static void PopuniComboKorisnik(ComboBox cmbKorisnik)
        {

            cmbKorisnik.Items.Clear();
            List<Korisnik> lista = (List<Korisnik>)komunikacija.VratiSveKorisnike();
            foreach (Korisnik d in lista)
            {
                cmbKorisnik.Items.Add(d);
            }

            cmbKorisnik.Text = "Izaberite korisnika!";
        }

      

        internal static void PopuniComboTip(ComboBox cmbTip)
        {
            cmbTip.Items.Clear();
            List<TipUsluge> lista = (List<TipUsluge>)komunikacija.VratiSveTipoveUsluga();
            foreach (TipUsluge a in lista)
            {
                cmbTip.Items.Add(a);
            }

            cmbTip.Text = "Izaberite tip usluge!";
        }

        internal static void PopuniComboKategorija(ComboBox cmbKat)
        {
            cmbKat.Items.Clear();
            List<Kategorija> lista = (List<Kategorija>)komunikacija.VratiSveKategorije();
            foreach (Kategorija k in lista)
            {
                cmbKat.Items.Add(k);
            }

            cmbKat.Text = "Izaberite kategoriju!";
        }

        internal static void PopuniComboZaposleni(ComboBox cmbZap)
        {
            cmbZap.Items.Clear();
            List<Zaposleni> lista = (List<Zaposleni>)komunikacija.VratiSveZaposlene();
            foreach (Zaposleni z in lista)
            {
                cmbZap.Items.Add(z);
            }

            cmbZap.Text = "Izaberite zaposlenog!";
        }


        internal static void KreirajKorisnika(TextBox txtSifra, GroupBox gbKorisnik, Button btnKreiraj)
        {
            korisnik = (Korisnik)komunikacija.KreirajKorisnika();

            if (korisnik == null)
            {
                MessageBox.Show("Sistem ne moze da kreira korisnika!");
            }
            else
            {
                MessageBox.Show("Sistem je uspesno kreirao korisnika!");
                txtSifra.Text = korisnik.Id.ToString();
                btnKreiraj.Enabled = false;
                gbKorisnik.Enabled = true;
            }
        }

        internal static bool ZapamtiKorisnika(TextBox txtIme, TextBox txtKontakt)
        {
            korisnik.ImePrezime = txtIme.Text;

            if (string.IsNullOrEmpty(korisnik.ImePrezime))
            {
                MessageBox.Show("Niste uneli ime i prezime!");
                return false;
            }

            korisnik.Kontakt = txtKontakt.Text;

            if (string.IsNullOrEmpty(korisnik.Kontakt))
            {
                MessageBox.Show("Niste uneli kontakt!");
                return false;
            }          
          
            Object rez = komunikacija.ZapamtiKorisnika(korisnik);

            if (rez == null)
            {
                MessageBox.Show("Sistem ne moze da zapamti korisnika!");
                return false;
            }
            else
            {
                MessageBox.Show("Sistem je zapamtio korisnika!");
                return true;
            }
        }

        internal static string PrikaziUlogovanogZaposlenog()
        {
            return "Ulogovan je: " +zaposleni.ToString()+" , Vreme prijave: "+DateTime.Now.ToString("HH:mm");
        }

        internal static void Kraj()
        {
            komunikacija.Kraj();
            komunikacija = null;
        }

        internal static bool Login( TextBox txtKorSifra)
        {
            zaposleni = new Zaposleni();            
            zaposleni.Id = txtKorSifra.Text;

            zaposleni = (Zaposleni)komunikacija.Login(zaposleni);

            if (zaposleni == null)
            {
                MessageBox.Show("Sistem ne moze da pronadje zaposlenog!");
                return false;
            }
            else
            {
                MessageBox.Show("Sistem je uspesno prijavio zaposlenog!");
                return true;
            }
        }
    }
}
