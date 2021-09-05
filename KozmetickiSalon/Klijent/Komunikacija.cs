using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Domen;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;

namespace Klijent
{
    public class Komunikacija
    {
        TcpClient klijent;
        NetworkStream tok;
        BinaryFormatter formater;

        public bool poveziSeNaServer()
        {
            try
            {
                klijent = new TcpClient("localhost", 20000);
                tok = klijent.GetStream();
                formater = new BinaryFormatter();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }


        public void Kraj()
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.Kraj;
            formater.Serialize(tok, transfer);
        }

        public Object Login(Zaposleni r)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.Login;
            transfer.TransferObjekat = r;
            formater.Serialize(tok, transfer);

            return ((TransferKlasa)formater.Deserialize(tok)).Rezultat;
        }

        public Object KreirajKorisnika()
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.KreirajKorisnika;
            transfer.TransferObjekat = new Korisnik();
            formater.Serialize(tok, transfer);

            return ((TransferKlasa)formater.Deserialize(tok)).Rezultat;
        }

        public Object ZapamtiKorisnika(Korisnik k)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.ZapamtiKorisnika;
            transfer.TransferObjekat = k;
            formater.Serialize(tok, transfer);

            return ((TransferKlasa)formater.Deserialize(tok)).Rezultat;
        }

        public Object PrikaziKorisnika(Korisnik k)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.PrikaziKorisnika;
            transfer.TransferObjekat = k;
            formater.Serialize(tok, transfer);

            return ((TransferKlasa)formater.Deserialize(tok)).Rezultat;
        }

        public Object PretraziKorisnike(Korisnik k)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.PretraziKorisnike;
            transfer.TransferObjekat = k;
            formater.Serialize(tok, transfer);

            return ((TransferKlasa)formater.Deserialize(tok)).Rezultat;
        }

        public Object ObrisiKorisnika(Korisnik k)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.ObrisiKorisnika;
            transfer.TransferObjekat = k;
            formater.Serialize(tok, transfer);

            return ((TransferKlasa)formater.Deserialize(tok)).Rezultat;
        }

      

        public Object KreirajUslugu()
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.KreirajUslugu;
            transfer.TransferObjekat = new Usluga();
            formater.Serialize(tok, transfer);

            return ((TransferKlasa)formater.Deserialize(tok)).Rezultat;
        }

        public Object ZapamtiUslugu(Usluga k)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.ZapamtiUslugu;
            transfer.TransferObjekat = k;
            formater.Serialize(tok, transfer);

            return ((TransferKlasa)formater.Deserialize(tok)).Rezultat;
        }

        public Object ObrisiUslugu(Usluga k)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.ObrisiUslugu;
            transfer.TransferObjekat = k;
            formater.Serialize(tok, transfer);

            return ((TransferKlasa)formater.Deserialize(tok)).Rezultat;
        }

        public Object PretraziUsluge(Usluga k)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.PretraziUsluge;
            transfer.TransferObjekat = k;
            formater.Serialize(tok, transfer);

            return ((TransferKlasa)formater.Deserialize(tok)).Rezultat;
        }

        public Object PrikaziUslugu(Usluga k)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.PrikaziUslugu;
            transfer.TransferObjekat = k;
            formater.Serialize(tok, transfer);

            return ((TransferKlasa)formater.Deserialize(tok)).Rezultat;
        }
        public Object VratiSveKategorije()
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.VratiSveKategorije;
            transfer.TransferObjekat = new Kategorija();
            formater.Serialize(tok, transfer);

            return ((TransferKlasa)formater.Deserialize(tok)).Rezultat;
        }

        public Object VratiSveTipoveUsluga()
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.VratiSveTipove;
            transfer.TransferObjekat = new TipUsluge();
            formater.Serialize(tok, transfer);

            return ((TransferKlasa)formater.Deserialize(tok)).Rezultat;
        }

        public Object VratiSveZaposlene()
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.VratiSveZaposlene;
            transfer.TransferObjekat = new Zaposleni();
            formater.Serialize(tok, transfer);

            return ((TransferKlasa)formater.Deserialize(tok)).Rezultat;
        }

        public Object VratiSveKorisnike()
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.VratiSveKorisnike;
            transfer.TransferObjekat = new Korisnik();
            formater.Serialize(tok, transfer);

            return ((TransferKlasa)formater.Deserialize(tok)).Rezultat;
        }


      

        public Object zapamtiTermin(Termin r)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.ZapamtiTermin;
            transfer.TransferObjekat = r;
            formater.Serialize(tok, transfer);

            return ((TransferKlasa)formater.Deserialize(tok)).Rezultat;
        }

     
        public Object PretraziTermine(Termin r)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.PretraziTermine;
            transfer.TransferObjekat = r;
            formater.Serialize(tok, transfer);

            return ((TransferKlasa)formater.Deserialize(tok)).Rezultat;
        }

        public Object PrikaziTermin(Termin r)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.PrikaziTermin;
            transfer.TransferObjekat = r;
            formater.Serialize(tok, transfer);

            return ((TransferKlasa)formater.Deserialize(tok)).Rezultat;
        }

        public Object VratiSveUsluge()
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.VratiSveUsluge;
            transfer.TransferObjekat = new Usluga();
            formater.Serialize(tok, transfer);

            return ((TransferKlasa)formater.Deserialize(tok)).Rezultat;
        }

    }
}
