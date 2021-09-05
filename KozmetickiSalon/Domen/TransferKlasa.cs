using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public enum Operacije { Kraj=1,
        Login = 2,
        KreirajKorisnika = 3,
        ObrisiKorisnika = 4,
        KreirajUslugu = 5,
        ZapamtiUslugu = 6,
        PretraziUsluge = 7,
        PrikaziUslugu = 8,
        ObrisiUslugu = 9,
        VratiSveTipove = 10,
        VratiSveKorisnike = 11,
        ZapamtiTermin = 13,
        PretraziTermine = 14,
        PrikaziTermin = 15,
        VratiSveUsluge = 17,
        PretraziKorisnike = 18,
        PrikaziKorisnika = 19,
        ZapamtiKorisnika = 20,
        VratiSveKategorije = 21,
        VratiSveZaposlene = 22,
    }
    [Serializable]
    public class TransferKlasa
    {
        public Operacije Operacija;
        public Object TransferObjekat;
        public Object Rezultat;
    }
}
