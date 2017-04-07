using Microsoft.VisualStudio.TestTools.UnitTesting;
using NajlepszyBankSA;
using NajlepszyBankSA.Interfejsy;
using NajlepszyBankSA.MechanizmyOdsetkowe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NajlepszyBankSA.Tests
{
    [TestClass()]
    public class BazowyMechanizmOdsetkowyTests
    {
        private IMechanizmOdsetkowy _mechanizm;
        private RachunekMock _rachunek;
        private class RachunekMock : IProdukt
        {
            private decimal _saldo;
            public IBank Bank
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

            public decimal DopuszczalnyDebet
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

            public IHistoriaOperacji Historia
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public string Numer
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

            public decimal Saldo
            {
                get
                {
                    return _saldo;
                }

                set
                {
                    _saldo = value;
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
        }

        [TestInitialize]
        public void Init()
        {
            _rachunek = new RachunekMock();
            _rachunek.Saldo = 1000;
            _mechanizm = new ProgowyMechanizmOdestkowyA(_rachunek);
        }

        [TestMethod()]
        public void MechanizmOdsetkowyNaliczanieOdsetek()
        {
            _mechanizm.Nalicz();
            Assert.IsTrue(_rachunek.Saldo >980);
        }
    }
}