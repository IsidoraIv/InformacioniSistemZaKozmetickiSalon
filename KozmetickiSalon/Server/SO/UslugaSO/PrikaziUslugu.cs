using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace Server.SO.UslugaSO
{
    public class PrikaziUslugu : OpstaSO
    {
        public override object IzvrsiKonkretnuSO(OpstiDomenskiObjekat odo)
        {
            // nepotrebno
            Usluga u = Broker.dajSesiju().VratiZaUslovPrimarni(odo) as Usluga;

            u.Tip = Broker.dajSesiju().VratiZaUslovPrimarni(u.Tip) as TipUsluge;
            u.Kategorija = Broker.dajSesiju().VratiZaUslovPrimarni(u.Kategorija) as Kategorija;

            List<Zaduzenje> lista = Broker.dajSesiju().vratiSveZaUslovOstalo(new Zaduzenje() { Usluga=u}).OfType<Zaduzenje>().ToList();

            foreach (Zaduzenje z in lista) 
            {
                z.Usluga = u;
                z.Zaposleni = Broker.dajSesiju().VratiZaUslovPrimarni(z.Zaposleni) as Zaposleni;
                u.ListaZaduzenja.Add(z);
            }

            return u;
        }
    }
}
