using Microsoft.VisualStudio.TestTools.UnitTesting;
using NajlepszyBankSA.Interfejsy;
using System;
using System.Collections.Generic;
using NajlepszyBankSA.Interfejsy.Operacje;

namespace NajlepszyBankSA.Tests
{
    [TestClass()]
    public class BankTests
    {
        private Bank _bank;
        private SystemPrzelewówMock _system;
        private PrzelewMock _przelew;
        private RachunekMock _rachunek1;
        private RachunekMock _rachunek2;
        private DrugiBankMock _bankInny;
        


        [TestInitialize]
        public void init()
        {
            _bank = new Bank();
            _system = new SystemPrzelewówMock();
            _przelew = new PrzelewMock();
            _rachunek1 = new RachunekMock();
            _rachunek2 = new RachunekMock();
            _przelew.RachunekDocelowy = _rachunek2;
            _przelew.RachunekWykonujący = _rachunek1;
            _bank.SystemPrzelewów = _system;
        }

        [TestMethod()]
        public void NadajPrzelewMiędzybankowyBankGenerujePrzelewTest()
        {
            _rachunek1.Bank = _bank;
            _rachunek2.Bank = _bankInny;

            _bank.NadajPrzelewMiędzybankowy(_przelew);
            Assert.IsNotNull(_system.przelewWykonany);
            Assert.AreEqual(_system.przelewWykonany.BankOdbiorcy, _bankInny);
        }

        [TestMethod()]
        public void NadajZwrotPrzelewuMiędzybankowegoBankGenerujePrzelewTest()
        {
            _rachunek1.Bank = _bankInny;
            _rachunek2.Bank = _bank;

            _bank.NadajZwrotPrzelewuMiędzybankowego(_przelew);
            Assert.IsNotNull(_system.przelewWykonany);
            Assert.AreEqual(_system.przelewWykonany.BankOdbiorcy, _bankInny);
        }


        private class DrugiBankMock : IBank
        {
            public IEnumerable<IKontoKlienta> kontaKlienta
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public void NadajPrzelewMiędzybankowy(IPrzelew podstawa)
            {
                throw new NotImplementedException();
            }

            public void NadajZwrotPrzelewuMiędzybankowego(IPrzelew nieprawidłowyPrzelew)
            {
                throw new NotImplementedException();
            }

            public void Wykonaj(IOperacjaBankowa operacja)
            {
                throw new NotImplementedException();
            }
        }

        private class RachunekMock : IRachunek
        {
            public IBank Bank
            {
                get;
                set;
            }

            public IHistoriaOperacji Historia
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public IMechanizmOdsetkowy MechanizmOdsetkowy
            {
                get
                {
                    throw new NotImplementedException();
                }

                set
                {
                    throw new NotImplementedException();
                }
            }

            public Guid Numer
            {
                get
                {
                    throw new NotImplementedException();
                }

                set
                {
                    throw new NotImplementedException();
                }
            }

            public IWłaściciel Właściciel
            {
                get
                {
                    throw new NotImplementedException();
                }

                set
                {
                    throw new NotImplementedException();
                }
            }

            public decimal __Saldo
            {
                get
                {
                    throw new NotImplementedException();
                }

                set
                {
                    throw new NotImplementedException();
                }
            }

            public void Pobierz(decimal kwota)
            {
                throw new NotImplementedException();
            }

            public void Wplac(decimal kwota)
            {
                throw new NotImplementedException();
            }
        }

        private class PrzelewMock : IPrzelew
        {
            public DateTime DataOperacji
            {
                get
                {
                    return DateTime.MinValue;
                }

                set
                {
                    throw new NotImplementedException();
                }
            }

            public decimal Kwota
            {
                get
                {
                    return 2000;
                }

                set
                {
                    throw new NotImplementedException();
                }
            }

            public string Opis
            {
                get
                {
                    return null;
                }
            }

            public IRachunek RachunekDocelowy
            {
                get;
                set;
            }

            public IRachunek RachunekWykonujący
            {
                get;
                set;
            }

            IProdukt IOperacjaBankowa.RachunekWykonujący
            {
                get
                {
                    return null;
                }

                set
                {
                    throw new NotImplementedException();
                }
            }

            public void accept(IVisitor visitor)
            {
                throw new NotImplementedException();
            }

            public bool Wykonaj()
            {
                throw new NotImplementedException();
            }
        }

        private class SystemPrzelewówMock : ISystemPrzelewówMiędzybankowych
        {
            public IOperacjaMiędzybankowa przelewWykonany;

            public void WykonajJeden(IOperacjaMiędzybankowa przelew)
            {
                przelewWykonany = przelew;
            }

            public void WykonajWiele(ICollection<IOperacjaMiędzybankowa> lista)
            {
                throw new NotImplementedException();
            }

            public void ZarejestrujBank(IBank bank)
            {
                throw new NotImplementedException();
            }
        }
    }
}