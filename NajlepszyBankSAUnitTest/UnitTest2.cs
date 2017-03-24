using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NajlepszyBankSA;

namespace UnitTest
{
    [TestClass]
    public class UnitTest2
    {
        //HistoriaOperacji historia = new HistoriaOperacji();
        MenadżerRaportów mr;
        //public UnitTest2()
        //{
        //    historia = new HistoriaOperacji();
        //    mr = new MenadżerRaportów(historia);

        //}


        //[TestMethod]
        //public void TestLogu()
        //{
        //    HistoriaOperacji historia = new HistoriaOperacji();
        //    LogOperacji log = new LogOperacji()
        //    {
        //        Data = DateTime.Today,
        //        Opis = "Opisik"
        //    };
        //    historia.Log(log);

        //    Assert.AreEqual(historia.Operacje.Count, 1);
        //    Assert.AreEqual(historia.Operacje[0].Opis, "Opisik");
        //}

        //[TestMethod]
        //[Timeout(500)]
        //public void TestRaportu_prep()
        //{


        //    for (int i = 0; i < 100000; i++)
        //    {
        //        historia.Log(new LogOperacji()
        //        {
        //            Data = DateTime.Now,
        //            Opis = DateTime.Now + " log"
        //        });
        //    }
        //}

        [TestMethod]
        [Timeout(200)]
        public void TestRaportu()
        {
            string s = mr.WykonarRaportGeneralny();
            Console.Out.Write(s);
        }

        [TestMethod]
        public void TestSalda()
        {
            Rachunek r1 = new Rachunek();
            r1.ZwiekszSaldo(20);
            r1.ZmniejszSaldo(30);
            decimal t1 = r1.GetSaldo();

            Assert.AreEqual(t1, 0);
        }
    }
}
