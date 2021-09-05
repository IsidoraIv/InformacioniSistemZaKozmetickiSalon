using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace Server.SO.KorisnikSO
{
    public class KreirajKorisnika : OpstaSO
    {
        public override object IzvrsiKonkretnuSO(OpstiDomenskiObjekat odo)
        {
            Korisnik d = new Korisnik();
            d.Id = Broker.dajSesiju().VratiSifru(d);
            Broker.dajSesiju().Sacuvaj(d);
            return d;
        }
    }
}
