﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
    public class RachunekTests
    {
        private Rachunek _rachunek;


        [TestInitialize]
        public void init()
        {
            _rachunek = new Rachunek(Guid.NewGuid(), new WłaśicielMock(), new BankMock());
            _rachunek.__Saldo = 1000M;
            _rachunek.DopuszczalnyDebet = 1000M;
        }

        [TestMethod()]
        public void WypłataZDopuszczalnymDebetem()
        {
            _rachunek.__Saldo -= 2000M;
            Assert.IsTrue(_rachunek.__Saldo == -1000M);
        }

        [TestMethod()]
        [ExpectedException(typeof(InvalidOperationException))]
        public void WypłataPrzekraczającaDebet()
        {
            _rachunek.__Saldo -= 3000M;
        }

        private class WłaśicielMock : IWłaściciel
        {
            public string KodPocztowy
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

            public string Miasto
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

            public string Nazwa
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public string NumerDomu
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

            public string NumerLokalu
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

            public string PełenAdres
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public string Ulica
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

        private class BankMock : IBank
        {
            public void Wykonaj(IOperacjaBankowa operacja)
            {
                throw new NotImplementedException();
            }
        }
    }
}