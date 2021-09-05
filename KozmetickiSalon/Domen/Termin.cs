using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class Termin:OpstiDomenskiObjekat
    {
        Zaposleni zaposleni;
        Korisnik korisnik;
        int terminID;
        DateTime datumTermina;
        DateTime datumZakazivanja;

        BindingList<StavkaTermina> stavkeTermina;

        [Browsable(false)]
        public Zaposleni Zaposleni { get => zaposleni; set => zaposleni = value; }
        public Korisnik Korisnik { get => korisnik; set => korisnik = value; }
        [Browsable(false)]
        public int TerminId { get => terminID; set => terminID = value; }
        public DateTime DatumZakazivanja { get => datumZakazivanja; set => datumZakazivanja = value; }
        public DateTime DatumTermina { get => datumTermina; set => datumTermina = value; }
       
        public BindingList<StavkaTermina> StavkeTermina { get => stavkeTermina; set => stavkeTermina = value; }
       

        public Termin()
        {
            stavkeTermina = new BindingList<StavkaTermina>();
        }


        [Browsable(false)]
        public string nazivTabele => "Termin";
        [Browsable(false)]
        public string primarniKljuc => "TerminID";
        [Browsable(false)]
        public string uslovPrimarni => "TerminID=" + terminID;
        [Browsable(false)]
        public string Uslov;
        [Browsable(false)]
        public string uslovOstalo => Uslov;
        [Browsable(false)]
        public string izmena => " DatumZakazivanja='"+datumZakazivanja.ToString("yyyy-MM-dd")+ "', DatumTermina='" + datumTermina.ToString("yyyy-MM-dd") + "', KorisnikId=" + Korisnik.Id+"";
        [Browsable(false)]
        public string unos => " values ('"+zaposleni.Id+"', " + Korisnik.Id + "," + TerminId + ", '" + datumZakazivanja.ToString("yyyy-MM-dd") + "', '" + datumTermina.ToString("yyyy-MM-dd") + "')";

      

        public OpstiDomenskiObjekat procitaj(System.Data.DataRow red)
        {
            Termin t = new Termin();
            t.TerminId = Convert.ToInt32(red["terminid"]);
            t.DatumZakazivanja= Convert.ToDateTime(red["DatumZakazivanja"]);
            t.DatumTermina= Convert.ToDateTime(red["DatumTermina"]);
            t.Korisnik = new Korisnik();
            t.Korisnik.Id = Convert.ToInt32(red["korisnikid"]);
            t.Zaposleni = new Zaposleni();
            t.Zaposleni.Id = red["zaposleniID"].ToString();
            return t;

        }

     
    }
}
