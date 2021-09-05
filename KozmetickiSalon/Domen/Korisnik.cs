using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class Korisnik:OpstiDomenskiObjekat
    {
        // atributi

        public override string ToString()
        {
            return ImePrezime;
        }

        int id;
        string imePrezime;
        string kontakt;
       

        [Browsable(false)]
        public int Id { get => id; set => id = value; }
        public string ImePrezime { get => imePrezime; set => imePrezime = value; }
        public string Kontakt { get => kontakt; set => kontakt = value; }
       
        // ODO deo

        [Browsable(false)]
        public string nazivTabele => "Korisnik";
        [Browsable(false)]
        public string primarniKljuc => "korisnikID";
        [Browsable(false)]
        public string uslovPrimarni => "korisnikID=" + Id;
        [Browsable(false)]
        public string USLOV;
        [Browsable(false)]
        public string uslovOstalo => USLOV;
        [Browsable(false)]
        public string izmena => " ImePrezime='"+ImePrezime+"', Kontakt='"+Kontakt+"'";
        [Browsable(false)]
        public string unos => "(korisnikID) values ("+Id+")";

       

        public OpstiDomenskiObjekat procitaj(DataRow red)
        {
            Korisnik k = new Korisnik();
            k.Id = Convert.ToInt32(red["korisnikID"]);
            k.ImePrezime = red["ImePrezime"].ToString();
            k.Kontakt = red["Kontakt"].ToString();     
            return k;
        }

        public override bool Equals(object obj)
        {
            return obj is Korisnik korisnik &&
                   id == korisnik.id;
        }
    }
}
