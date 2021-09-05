using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace Server.SO.TerminSO
{
    public class PrikaziTermin : OpstaSO
    {
        public override object IzvrsiKonkretnuSO(OpstiDomenskiObjekat odo)
        {
            Termin t = odo as Termin;

            t.Korisnik = Broker.dajSesiju().VratiZaUslovPrimarni(t.Korisnik) as Korisnik;

            StavkaTermina sta = new StavkaTermina();
            sta.Uslov = "TerminID=" + t.TerminId;

            List<StavkaTermina> lista = Broker.dajSesiju().vratiSveZaUslovOstalo(sta).OfType<StavkaTermina>().ToList();

            foreach (StavkaTermina st in lista)
            {
                st.Usluga = Broker.dajSesiju().VratiZaUslovPrimarni(st.Usluga) as Usluga;
                st.Usluga.Tip= Broker.dajSesiju().VratiZaUslovPrimarni(st.Usluga.Tip) as TipUsluge;              
                t.StavkeTermina.Add(st);
            }

            return t;
        }
    }
}
