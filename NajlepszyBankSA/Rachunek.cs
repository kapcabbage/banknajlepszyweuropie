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
        protected decimal _dopuszczalnyDebet;


        public decimal DopuszczalnyDebet
        {
            get
            {
                return _dopuszczalnyDebet;
            }

            set
            {
                _dopuszczalnyDebet = value;
            }
        }

        new public decimal Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if(value < -1 * _dopuszczalnyDebet)
                {
                    throw new InvalidOperationException();
                }
                _saldo = value;
            }
        }
        
        public Rachunek(string numer, IWłaściciel właściciel, IBank bank) : base(numer, właściciel, bank) 
        {
        }

    }
}
