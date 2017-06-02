using NajlepszyBankSA.Interfejsy;
using NajlepszyBankSA.Interfejsy.Operacje;
using NajlepszyBankSA.Operacje;
using PostSharp.Aspects;
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

        [AspectBanking]
        public void Wykonaj(IOperacjaBankowa operacja)
        {
            operacja.Wykonaj(); 
            _historia.Operacje.Add(operacja);
            operacja.RachunekWykonujący.Historia.Operacje.Add(operacja);
        }

        [AspectBanking]
        public void NadajPrzelewMiędzybankowy(IPrzelew podstawa)
        {
            PrzelewMiędzybankowy przelewMiędzybankowy = new PrzelewMiędzybankowy(podstawa.RachunekWykonujący, podstawa.RachunekDocelowy, podstawa.Kwota);
            _systemPrzelewow.WykonajJeden(przelewMiędzybankowy);
        }
        [AspectBanking]
        public void NadajZwrotPrzelewuMiędzybankowego(IPrzelew nieprawidłowyPrzelew)
        {
            ZwrotPrzelewuMiędzybankowego przelewMiędzybankowy = new ZwrotPrzelewuMiędzybankowego(nieprawidłowyPrzelew.RachunekDocelowy, nieprawidłowyPrzelew.RachunekWykonujący, nieprawidłowyPrzelew.Kwota);
            _systemPrzelewow.WykonajJeden(przelewMiędzybankowy);
        }


        [Serializable]
        public class AspectBanking : OnMethodBoundaryAspect
        {
            public override void OnExit(MethodExecutionArgs args)
            {
                Console.WriteLine("2zł for performing operation");
                IOperacjaBankowa operacja = (IOperacjaBankowa)args.Arguments[0];
                if (operacja.RachunekWykonujący is IRachunek)
                {
                    IRachunek rachunek = (IRachunek)operacja.RachunekWykonujący;
                    Wyplata wyplata = new Wyplata(rachunek, 2M);
                    wyplata.Wykonaj();
                }
            }

            public override void OnException(MethodExecutionArgs args)
            {
                Console.WriteLine("Dummy client, for trying to cheat on us we take your money.");
                IOperacjaBankowa operacja = (IOperacjaBankowa)args.Arguments[0];
                if (operacja.RachunekWykonujący is IRachunek)
                {
                    IRachunek rachunek = (IRachunek)operacja.RachunekWykonujący;
                    Wyplata wyplata = new Wyplata(rachunek, 100M);
                    wyplata.Wykonaj();
                }
                args.FlowBehavior = FlowBehavior.RethrowException;
            }
        }
    }
}
