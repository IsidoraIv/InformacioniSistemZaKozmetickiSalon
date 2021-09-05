using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace Server.SO.TerminSO
{
    public class ZapamtiTermin : OpstaSO
    {
        public override object IzvrsiKonkretnuSO(OpstiDomenskiObjekat odo)
        {
            Termin t = odo as Termin;
            t.TerminId = Broker.dajSesiju().VratiSifru(t);

            Broker.dajSesiju().Sacuvaj(t);

          
            foreach (StavkaTermina st in t.StavkeTermina)
            {
                st.TerminID = t.TerminId;
                Broker.dajSesiju().Sacuvaj(st);
            }


            return t;
        }
    }
}
