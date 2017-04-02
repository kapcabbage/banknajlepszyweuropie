using Microsoft.VisualStudio.TestTools.UnitTesting;
using NajlepszyBankSA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NajlepszyBankSA.Tests
{
    [TestClass()]
    public class OsobaTests
    {
        Osoba _osoba;

        [TestInitialize]
        public void init()
        {
            _osoba = new Osoba("jacek", "senny", "66666666666");
            _osoba.Miasto = "Poznań";
            _osoba.NumerDomu = "10";
            _osoba.KodPocztowy = "66-666";
            _osoba.Ulica = "Piotrowo";
        }

        [TestMethod()]
        public void OsobaNazwaZawieraPodstawoweElementy()
        {
            string nazwaLow = _osoba.Nazwa.ToLower();
            Assert.IsTrue(nazwaLow.Contains("jacek") && nazwaLow.Contains("senny"));
        }

        [TestMethod()]
        public void OsobaPełenAdresZawieraUlicęIMiasto()
        {
            string adresLow = _osoba.PełenAdres.ToLower();
            Assert.IsTrue(adresLow.Contains("poznań") && adresLow.Contains("piotrowo"));
        }
    }
}