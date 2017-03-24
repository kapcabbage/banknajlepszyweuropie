using NajlepszyBankSA.Interfejsy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NajlepszyBankSA
{
    public class Bank : IBank
    {   
        private List<KontoKlienta> Konta { get; set; }

        public void stworzPospolitegoKlienta(string imie, string nazwisko, string pesel)
        {
            Osoba Klient = new Osoba(imie, nazwisko, pesel);
            KontoKlienta Konto = new KontoKlienta(Klient);

            Konta.Add(Konto);
        }

        public void stworzRachunek(KontoKlienta Klient)
        {

        }

        public void Wykonaj(IOperacjaBankowa operacja)
        {
            throw new NotImplementedException();
        }
    }
}
