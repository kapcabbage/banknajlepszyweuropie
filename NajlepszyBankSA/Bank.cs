using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NajlepszyBankSA
{
    public class Bank
    {   
        private List<KontoKlienta> Konta { get; set; }

        public void stworzKlienta(string Imie, string Nazwisko)
        {
            Osoba Klient = new Osoba(Imie, Nazwisko);
            KontoKlienta Konto = new KontoKlienta(Klient);

            Konta.Add(Konto);
        }

        public void stworzRachunek(KontoKlienta Klient)
        {

        }
    }
}
