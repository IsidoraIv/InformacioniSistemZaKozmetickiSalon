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
    public class TipUsluge:OpstiDomenskiObjekat
    {

        // atributi

        public override string ToString()
        {
            return Naziv;
        }

        int id;
        string naziv;
       

        public int Id { get => id; set => id = value; }
        public string Naziv { get => naziv; set => naziv = value; }
      

        // ODO deo

        [Browsable(false)]
        public string nazivTabele => "TipUsluge";
        [Browsable(false)]
        public string primarniKljuc => "tipID";
        [Browsable(false)]
        public string uslovPrimarni => "tipID="+Id;
        [Browsable(false)]
        public string uslovOstalo => null;
        [Browsable(false)]
        public string izmena => null;
        [Browsable(false)]
        public string unos => null;

        public OpstiDomenskiObjekat procitaj(DataRow red)
        {
            TipUsluge t = new TipUsluge();
            t.Id = Convert.ToInt32(red["tipID"]);
            t.Naziv = red["Naziv"].ToString();
          
            return t;
        }
    }
}
