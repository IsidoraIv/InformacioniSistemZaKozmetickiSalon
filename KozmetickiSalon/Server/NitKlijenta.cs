using System;
using Domen;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;

using Server.SO.KorisnikSO;
using Server.SO.UslugaSO;
using Server.SO.ZaposleniSO;
using Server.SO.TerminSO;

namespace Server
{
    class NitKlijenta
    {
        private NetworkStream tok;
        BinaryFormatter formater;

        public NitKlijenta(NetworkStream tok)
        {
            this.tok = tok;
            formater = new BinaryFormatter();

            ThreadStart ts = obradi;
            new Thread(ts).Start();
        }

        void obradi()
        {
            try
            {
                int operacija = 0;
                while (operacija != (int)Operacije.Kraj)
                {
                    TransferKlasa transfer = formater.Deserialize(tok) as TransferKlasa;
                    switch (transfer.Operacija)
                    {

                        case Operacije.Login:
                            PrijaviZaposlenog log = new PrijaviZaposlenog();
                            transfer.Rezultat = log.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.KreirajKorisnika:
                            KreirajKorisnika knd = new KreirajKorisnika();
                            transfer.Rezultat = knd.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.ZapamtiKorisnika:
                            ZapamtiKorisnika zd = new ZapamtiKorisnika();
                            transfer.Rezultat = zd.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.PretraziKorisnike:
                            PretraziKorisnike pke = new PretraziKorisnike();
                            transfer.Rezultat = pke.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.PrikaziKorisnika:
                            PrikaziKorisnika pk = new PrikaziKorisnika();
                            transfer.Rezultat = pk.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.VratiSveKategorije:
                            VratiLIstuKategorija ok = new VratiLIstuKategorija();
                            transfer.Rezultat = ok.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.KreirajUslugu:
                            KreirajUslugu knk = new KreirajUslugu();
                            transfer.Rezultat = knk.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.ZapamtiUslugu:
                            ZapamtiUslugu zk = new ZapamtiUslugu();
                            transfer.Rezultat = zk.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.PretraziUsluge:
                            PretraziUsluge pu = new PretraziUsluge();
                            transfer.Rezultat = pu.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.PrikaziUslugu:
                            PrikaziUslugu uk = new PrikaziUslugu();
                            transfer.Rezultat = uk.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.ObrisiUslugu:
                            ObrisiUslugu ou = new ObrisiUslugu();
                            transfer.Rezultat = ou.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.VratiSveTipove:
                            VratiListuTipovaUsluga vsa = new VratiListuTipovaUsluga();
                            transfer.Rezultat = vsa.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.VratiSveKorisnike:
                            VratiLIstuKorisnika vsd = new VratiLIstuKorisnika();
                            transfer.Rezultat = vsd.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.VratiSveUsluge:
                            VratiLIstuUsluga vlu = new VratiLIstuUsluga();
                            transfer.Rezultat = vlu.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.VratiSveZaposlene:
                            VratiListuZaposlenih vlz = new VratiListuZaposlenih();
                            transfer.Rezultat = vlz.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.ZapamtiTermin:
                            ZapamtiTermin zr = new ZapamtiTermin();
                            transfer.Rezultat = zr.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.PretraziTermine:
                            PretraziTermine pr = new PretraziTermine();
                            transfer.Rezultat = pr.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.PrikaziTermin:
                            PrikaziTermin ur = new PrikaziTermin();
                            transfer.Rezultat = ur.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                    
                      

                        case Operacije.Kraj:
                            operacija = 1;
                            Server.listaTokova.Remove(tok);
                            break;
                        default:
                            break;
                    }
                }
            }
            catch (Exception)
            {
                Server.listaTokova.Remove(tok);
            }
        }
    }
}
