using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SO.UslugaSO
{
    public class ZapamtiUslugu:OpstaSO
    {
        public override object IzvrsiKonkretnuSO(OpstiDomenskiObjekat odo)
        {
            Usluga u = odo as Usluga;
            Broker.dajSesiju().IzmeniUslovPrimarni(odo);

            Zaduzenje z = new Zaduzenje() { Usluga=u};
            Broker.dajSesiju().ObrisiZaUslovOstalo(z);
            foreach (Zaduzenje za in u.ListaZaduzenja) 
            {
                Broker.dajSesiju().Sacuvaj(za);
            }

            return u;
        }
    }
}
