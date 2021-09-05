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
    public class Zaduzenje:OpstiDomenskiObjekat
    {
        Usluga usluga;
        Zaposleni zaposleni;
        int brUsluga;

        [Browsable(false)]
        public Usluga Usluga { get => usluga; set => usluga = value; }
        public Zaposleni Zaposleni { get => zaposleni; set => zaposleni = value; }
        public int BrUsluga { get => brUsluga; set => brUsluga = value; }

        // ODO deo

        [Browsable(false)]
        public string nazivTabele => "Zaduzenje";
        [Browsable(false)]
        public string primarniKljuc => "";
        [Browsable(false)]
        public string uslovPrimarni => "";
        [Browsable(false)]
        public string USLOV;
        [Browsable(false)]
        public string uslovOstalo => "UslugaID="+usluga.Id;
        [Browsable(false)]
        public string izmena => " UslugaID=" + usluga.Id + ", ZaposleniID='" + zaposleni.Id + "', BrojUsluga=" + brUsluga + " ";
        [Browsable(false)]
        public string unos => " values ('"+zaposleni.Id+"'," + usluga.Id + ","+brUsluga+")";



        public OpstiDomenskiObjekat procitaj(DataRow red)
        {
            Zaduzenje z = new Zaduzenje();
            z.Usluga = new Usluga();
            z.Usluga.Id = Convert.ToInt32(red["UslugaID"]);
            z.Zaposleni = new Zaposleni();
            z.Zaposleni.Id = red["ZaposleniID"].ToString();
            z.BrUsluga = Convert.ToInt32(red["BrojUsluga"]);

            return z;
        }
    }
}
