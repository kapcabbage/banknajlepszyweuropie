using Microsoft.VisualStudio.TestTools.UnitTesting;
using NajlepszyBankSA;
using NajlepszyBankSA.Interfejsy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NajlepszyBankSA.Tests
{
    [TestClass()]
    public class SplataKredytuTests
    {
        private SplataKredytu _splata;
        private KredytMock _kredyt;
        private RachunekMock _rachunek;

        [TestInitialize]
        public void Init()
        {
            _kredyt = new KredytMock();
            _rachunek = new RachunekMock();
            _kredyt.RachunekPowiazany = _rachunek;
            _splata = new SplataKredytu(_kredyt, 1000M);
        }

        [TestMethod()]
        public void SpłataKredytuWykonanie()
        {
            _kredyt.__Saldo = 2000M;
            _rachunek.__Saldo = 1000M;
            _splata.Wykonaj();
            Assert.AreEqual(_kredyt.__Saldo, 1000M);
            Assert.AreEqual(_rachunek.__Saldo, 0M);
        }

        private class KredytMock : IKredyt
        {
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

            public IHistoriaOperacji Historia
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public IRachunek RachunekPowiazany
            {
                get;
                set;
            }

            public decimal __Saldo
            {
                get;
                set;
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
        private class RachunekMock : IRachunek
        {
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

           


            public decimal __Saldo
            {
                get;
                set;
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
        }
    }
}