using NajlepszyBankSA.Interfejsy;
using NajlepszyBankSA.Interfejsy.Operacje;
using NajlepszyBankSA.Operacje;
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
        protected ISystemPrzelewówMiędzybankowych _systemPrzelewow;

        public ISystemPrzelewówMiędzybankowych SystemPrzelewów
        {
            get
            {
                return _systemPrzelewow;
            }
            set
            {
                _systemPrzelewow = value;
            }
        }

        public IEnumerable<IKontoKlienta> kontaKlienta
        {
            get
            {
                return _konta;
            }
        }

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

        public void NadajPrzelewMiędzybankowy(IPrzelew podstawa)
        {
            PrzelewMiędzybankowy przelewMiędzybankowy = new PrzelewMiędzybankowy(podstawa.RachunekWykonujący, podstawa.RachunekDocelowy, podstawa.Kwota);
            _systemPrzelewow.WykonajJeden(przelewMiędzybankowy);
        }
        public void NadajZwrotPrzelewuMiędzybankowego(IPrzelew nieprawidłowyPrzelew)
        {
            ZwrotPrzelewuMiędzybankowego przelewMiędzybankowy = new ZwrotPrzelewuMiędzybankowego(nieprawidłowyPrzelew.RachunekDocelowy, nieprawidłowyPrzelew.RachunekWykonujący, nieprawidłowyPrzelew.Kwota);
            _systemPrzelewow.WykonajJeden(przelewMiędzybankowy);
        }
    }
}
