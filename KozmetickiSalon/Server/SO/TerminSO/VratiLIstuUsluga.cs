using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace Server.SO.TerminSO
{
    public class VratiLIstuUsluga : OpstaSO
    {
        public override object IzvrsiKonkretnuSO(OpstiDomenskiObjekat odo)
        {
            Usluga k = new Usluga();
            k.Uslov = "naziv is null";

            Broker.dajSesiju().ObrisiZaUslovOstalo(k);

            return Broker.dajSesiju().vratiSve(odo).OfType<Usluga>().ToList<Usluga>();
        }
    }
}
