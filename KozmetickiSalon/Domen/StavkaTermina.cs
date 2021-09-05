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
    public class StavkaTermina : OpstiDomenskiObjekat
    {
        int terminID;
        int rbr;
        Usluga usluga;

        [Browsable(false)]
        public int TerminID { get => terminID; set => terminID = value; }
        public int Rbr { get => rbr; set => rbr = value; }       
        public Usluga Usluga { get => usluga; set => usluga = value; }

        [Browsable(false)]
        public string nazivTabele => "StavkaTermina";
        [Browsable(false)]
        public string primarniKljuc => "";
        [Browsable(false)]
        public string uslovPrimarni => "";
        [Browsable(false)]
        public string Uslov;
        [Browsable(false)]
        public string uslovOstalo => Uslov;
        [Browsable(false)]
        public string izmena => "";
        [Browsable(false)]
        public string unos => "values (" + terminID + "," + rbr + "," + usluga.Id + ")";

       

        public OpstiDomenskiObjekat procitaj(System.Data.DataRow red)
        {
            StavkaTermina st = new StavkaTermina();
            st.terminID = Convert.ToInt32(red["terminID"]);
            st.Rbr = Convert.ToInt32(red["rbr"]);          
            st.Usluga = new Usluga();
            st.Usluga.Id = Convert.ToInt32(red["uslugaId"]);

            return st;
        }

       
    }
}