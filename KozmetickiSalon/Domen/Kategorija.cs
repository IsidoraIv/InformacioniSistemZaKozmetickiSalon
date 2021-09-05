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
    public class Kategorija:OpstiDomenskiObjekat
    {
        public override string ToString()
        {
            return naziv;
        }

        public override bool Equals(object obj)
        {
            return obj is Kategorija kategorija &&
                   id == kategorija.id;
        }

        int id;
        string naziv;
        string opis;

        public int Id { get => id; set => id = value; }
        public string Naziv { get => naziv; set => naziv = value; }
        public string Opis { get => opis; set => opis = value; }

        // ODO deo

        [Browsable(false)]
        public string nazivTabele => "Kategorija";
        [Browsable(false)]
        public string primarniKljuc => "KategorijaID";
        [Browsable(false)]
        public string uslovPrimarni => "KategorijaID=" + Id;
        [Browsable(false)]
        public string USLOV;
        [Browsable(false)]
        public string uslovOstalo => USLOV;
        [Browsable(false)]
        public string izmena => "";
        [Browsable(false)]
        public string unos => "";



        public OpstiDomenskiObjekat procitaj(DataRow red)
        {
            Kategorija k = new Kategorija();
            k.Id = Convert.ToInt32(red["KategorijaID"]);
            k.Naziv = red["Naziv"].ToString();
            k.Opis = red["Opis"].ToString();
            return k;
        }

      
    }
}
