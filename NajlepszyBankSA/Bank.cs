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
        protected List<KontoKlienta> _konta;
        protected HistoriaOperacji _historia;

        public void stworzPospolitegoKlienta(string imie, string nazwisko, string pesel)
        {
            Osoba Klient = new Osoba(imie, nazwisko, pesel);
            KontoKlienta Konto = new KontoKlienta(Guid.NewGuid(),Klient);

            _konta.Add(Konto);
        }

        public void stworzZwyczajnyRachunek(KontoKlienta Klient)
        {

        }

        public void Wykonaj(IOperacjaBankowa operacja)
        {
            operacja.Wykonaj();
            _historia.Operacje.Add(operacja);
            operacja.RachunekWykonujący.Historia.Operacje.Add(operacja);
        }
    }
}
