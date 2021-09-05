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
    public class Usluga:OpstiDomenskiObjekat
    {
        // atributi

        public override string ToString()
        {
            return Naziv;
        }

        int id;
        string naziv;
        string opis;
        int cena;
        TipUsluge tip;
        Kategorija kategorija;

        BindingList<Zaduzenje> listaZaduzenja;

        public Usluga()
        {
            listaZaduzenja = new BindingList<Zaduzenje>();
        }
        [Browsable(false)]
        public int Id { get => id; set => id = value; }
        public string Naziv { get => naziv; set => naziv = value; }     
        public string Opis { get => opis; set => opis = value; }
        public int Cena { get => cena; set => cena = value; }
        [Browsable(false)]
        public TipUsluge Tip { get => tip; set => tip = value; }
        [Browsable(false)]
        public Kategorija Kategorija{ get => kategorija; set => kategorija = value; }

        public BindingList<Zaduzenje> ListaZaduzenja { get => listaZaduzenja; set => listaZaduzenja = value; }
        // ODO deo

        [Browsable(false)]
        public string nazivTabele => "Usluga";
        [Browsable(false)]
        public string primarniKljuc => "uslugaID";
        [Browsable(false)]
        public string uslovPrimarni => "uslugaID=" + Id;
        [Browsable(false)]
        public string Uslov=" Naziv is null";
        [Browsable(false)]
        public string uslovOstalo => Uslov;
        [Browsable(false)]
        public string izmena => " Naziv='"+naziv+"',  Opis='"+Opis+"',Cena="+cena+", tipID="+tip.Id+", kategorijaID="+kategorija.Id+"";
        [Browsable(false)]
        public string unos => "(uslugaID) values (" + Id+")";

      

        public OpstiDomenskiObjekat procitaj(DataRow red)
        {
            Usluga u = new Usluga();
            u.Id = Convert.ToInt32(red["uslugaID"]);
            u.Naziv = red["naziv"].ToString();
            u.Opis = red["opis"].ToString();
            u.Cena = Convert.ToInt32(red["Cena"]);
            u.Tip = new TipUsluge();
            u.Tip.Id = Convert.ToInt32(red["tipID"]);
            u.Kategorija = new Kategorija();
            u.Kategorija.Id = Convert.ToInt32(red["KategorijaID"]);

            return u;
        }

        public override bool Equals(object obj)
        {
            var usluga = obj as Usluga;
            return usluga != null &&
                   id == usluga.id;
        }
    }
}
