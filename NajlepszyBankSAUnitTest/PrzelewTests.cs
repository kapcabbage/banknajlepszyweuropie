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
    public class PrzelewTests
    {
        private Przelew _przelew;
        private Rachunek _rachunek1;
        private Rachunek _rachunek2;

        [TestInitialize]
        public void Init()
        {
            _rachunek1 = new Rachunek(Guid.NewGuid().ToString(), new WłaścicielMock(), new BankMock());
            _rachunek1.Saldo = 1000M;
            _rachunek2 = new Rachunek(Guid.NewGuid().ToString(), new WłaścicielMock(), new BankMock());
            _rachunek2.Saldo = 2000M;
        }

        [TestMethod()]
        public void PrzelewNiewystarczająceŚrodki()
        {
            _przelew = new Przelew(_rachunek1, _rachunek2, 2000);
            Assert.IsFalse(_przelew.Wykonaj());
            Assert.AreEqual(_rachunek1.Saldo, 1000M);
            Assert.AreEqual(_rachunek2.Saldo, 2000M);
        }

        [TestMethod()]
        public void PrzelewWykonany()
        {
            _przelew = new Przelew(_rachunek1, _rachunek2, 1000);
            Assert.IsTrue(_przelew.Wykonaj());
            Assert.AreEqual(_rachunek1.Saldo, 0M);
            Assert.AreEqual(_rachunek2.Saldo, 3000M);
        }

        private class BankMock : IBank
        {
            public void Wykonaj(IOperacjaBankowa operacja)
            {
                throw new NotImplementedException();
            }
        }

        public class WłaścicielMock : IWłaściciel
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
    }
}