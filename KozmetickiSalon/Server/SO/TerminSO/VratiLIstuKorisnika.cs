using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace Server.SO.TerminSO
{
    public class VratiLIstuKorisnika : OpstaSO
    {
        public override object IzvrsiKonkretnuSO(OpstiDomenskiObjekat odo)
        {
            Korisnik k = new Korisnik();
            k.USLOV = "ImePrezime is null";

            Broker.dajSesiju().ObrisiZaUslovOstalo(k);

            return Broker.dajSesiju().vratiSve(odo).OfType<Korisnik>().ToList<Korisnik>();
        }
    }
}
