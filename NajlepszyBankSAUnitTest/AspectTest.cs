using Microsoft.VisualStudio.TestTools.UnitTesting;
using NajlepszyBankSA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NajlepszyBankSAUnitTest
{
    [TestClass()]
    class AspectTest
    {
        private Bank _bank;
        private Rachunek _rachunek1;
        private Rachunek _rachunek2;
        private Przelew _przelew;
        private Wplata _wplata;


        [TestInitialize]
        public void init()
        {
            _bank = new Bank();
            _rachunek1 = new Rachunek(Guid.NewGuid(),new Osoba("","",""),_bank);
            _rachunek2 = new Rachunek(Guid.NewGuid(), new Osoba("", "", ""), _bank);
            _wplata = new Wplata(_rachunek1, 1000);
            _wplata.Wykonaj();
            _wplata = new Wplata(_rachunek2, 2000);
            _wplata.Wykonaj();
        }
    }
}
