using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace Server.SO.UslugaSO
{
    public class PretraziUsluge : OpstaSO
    {
        public override object IzvrsiKonkretnuSO(OpstiDomenskiObjekat odo)
        {
            return Broker.dajSesiju().vratiSveZaUslovOstalo(odo).OfType<Usluga>().ToList<Usluga>();
        }
    }
}
