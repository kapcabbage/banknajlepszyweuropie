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
    public class LokataTests
    {
        private Lokata _lokata;

        [TestInitialize]
        public void Init()
        {
            _lokata = new Lokata(Guid.NewGuid(), new WłaścicielMock(), new BankMock(), 1000M);
        }

        [TestMethod()]
        [ExpectedException(typeof(InvalidOperationException))]
        public void LokataSaldoNieMożnaModyfikować()
        {
            _lokata.Saldo -= 100M;
        }

        private class WłaścicielMock : IWłaściciel
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