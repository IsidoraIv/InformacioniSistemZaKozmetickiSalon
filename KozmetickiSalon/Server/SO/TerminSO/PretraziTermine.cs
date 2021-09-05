using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace Server.SO.TerminSO
{
    public class PretraziTermine : OpstaSO
    {
        public override object IzvrsiKonkretnuSO(OpstiDomenskiObjekat odo)
        {
            List<Termin> lista= Broker.dajSesiju().vratiSveZaUslovOstalo(odo).OfType<Termin>().ToList<Termin>();

            foreach (Termin t in lista)
            {
                t.Korisnik = Broker.dajSesiju().VratiZaUslovPrimarni(t.Korisnik) as Korisnik;
            }

            return lista;
        }
    }
}
