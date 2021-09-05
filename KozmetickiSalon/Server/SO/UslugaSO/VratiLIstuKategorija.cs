using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SO.UslugaSO
{
    public class VratiLIstuKategorija : OpstaSO
    {
        public override object IzvrsiKonkretnuSO(OpstiDomenskiObjekat odo)
        {
            return Broker.dajSesiju().vratiSve(odo).OfType<Kategorija>().ToList();
        }
    }
}
