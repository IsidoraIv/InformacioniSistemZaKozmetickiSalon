using Domen;
using Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SO
{
    public abstract class OpstaSO
    {
        public Object IzvrsiSO(OpstiDomenskiObjekat odo)
        {
            Object rezultat = null;
            try
            {
                Broker.dajSesiju().otvoriKonekciju();
                Broker.dajSesiju().zapocniTransakciju();
                rezultat = IzvrsiKonkretnuSO(odo);
                Broker.dajSesiju().potvrdiTransakciju();                
            }
            catch (Exception)
            {
                Broker.dajSesiju().ponistiTransakciju();               
            }
            finally
            {
                Broker.dajSesiju().zatvoriKonekciju();
            }
            return rezultat;
        }

        public abstract Object IzvrsiKonkretnuSO(OpstiDomenskiObjekat odo);
    }
}
