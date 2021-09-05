using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;
using Server;

namespace Server.SO.KorisnikSO
{
    public class ZapamtiKorisnika : OpstaSO
    {
        public override object IzvrsiKonkretnuSO(OpstiDomenskiObjekat odo)
        {
            return Broker.dajSesiju().IzmeniUslovPrimarni(odo);
        }
    }
}
