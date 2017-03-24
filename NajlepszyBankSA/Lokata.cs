using NajlepszyBankSA.Interfejsy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NajlepszyBankSA
{
    public class Lokata : Produkt
    {
        public IMechanizmOdsetkowy MechanizmOdsetkowy { get; set; }

        Lokata(string numer, IWłaściciel właściciel, IBank bank) : base(numer, właściciel, bank)
        {

        }
    }
}
