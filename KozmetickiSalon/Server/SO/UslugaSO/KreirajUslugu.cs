using Domen;
using Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SO.UslugaSO
{
    public class KreirajUslugu:OpstaSO
    {
        public override object IzvrsiKonkretnuSO(OpstiDomenskiObjekat odo)
        {
            Usluga u = new Usluga();
            u.Id = Broker.dajSesiju().VratiSifru(u);
            Broker.dajSesiju().Sacuvaj(u);
            return u;
        }
    }
}
