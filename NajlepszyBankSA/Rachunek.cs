using NajlepszyBankSA.Interfejsy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NajlepszyBankSA
{
    public class Rachunek : Produkt, IRachunek
    {
        protected decimal _debet;

        public decimal Debet
        {
            get;
            set;
        }
        
        public Rachunek(string numer, IWłaściciel właściciel, IBank bank) : base(numer, właściciel, bank) 
        {
        }

    }
}
