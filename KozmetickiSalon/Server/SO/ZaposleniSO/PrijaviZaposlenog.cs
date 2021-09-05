using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;
using Server;

namespace Server.SO.ZaposleniSO
{
    public class PrijaviZaposlenog : OpstaSO
    {
        public override object IzvrsiKonkretnuSO(OpstiDomenskiObjekat odo)
        {
            Zaposleni z= Broker.dajSesiju().VratiZaUslovPrimarni(odo) as Zaposleni;
            if (z != null)
            {
                  z.Kategorija = Broker.dajSesiju().VratiZaUslovPrimarni(z.Kategorija) as Kategorija;
            }
            return z;
        }
    }
}
