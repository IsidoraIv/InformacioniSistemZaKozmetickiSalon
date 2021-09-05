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
    public class Zaposleni:OpstiDomenskiObjekat
    {
        // atributi

        public override string ToString()
        {
            return ImePrezime;
        }

        string id;
        string imePrezime;
        DateTime datumRodjenja;
        string brTelefona;
        Kategorija kategorija;

        public string Id { get => id; set => id = value; }
        public string ImePrezime { get => imePrezime; set => imePrezime = value; }
        public DateTime DatumRodjenja { get => datumRodjenja; set => datumRodjenja = value; }
        public string BrTelefona { get => brTelefona; set => brTelefona = value; }
        public Kategorija Kategorija { get => kategorija; set => kategorija = value; }

        // ODO deo

        [Browsable(false)]
        public string nazivTabele => "Zaposleni";
        [Browsable(false)]
        public string primarniKljuc => "zaposleniID";
        [Browsable(false)]
        public string uslovPrimarni => "zaposleniID='" + Id+"'";
        [Browsable(false)]
        public string uslovOstalo => "";
        [Browsable(false)]
        public string izmena => null;
        [Browsable(false)]
        public string unos => null;

        public OpstiDomenskiObjekat procitaj(DataRow red)
        {
            Zaposleni z = new Zaposleni();
            z.Id = red["zaposleniID"].ToString();
            z.ImePrezime = red["ImePrezime"].ToString();
            z.DatumRodjenja = Convert.ToDateTime(red["DatumRodjenja"]);
            z.BrTelefona = red["BrojTelefona"].ToString();
            z.Kategorija = new Kategorija();
            z.Kategorija.Id = Convert.ToInt32(red["KategorijaID"]);

            return z;
        }

        public override bool Equals(object obj)
        {
            return obj is Zaposleni zaposleni &&
                   id == zaposleni.id;
        }
    }
}
