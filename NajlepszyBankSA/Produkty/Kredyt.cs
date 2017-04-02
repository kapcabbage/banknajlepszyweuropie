using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NajlepszyBankSA.Interfejsy;

namespace NajlepszyBankSA
{
    public class Kredyt : Produkt, IKredyt
    {
        protected IRachunek _rachunek;
        protected IWłaściciel _wlasciciel;
        
        public Kredyt(Guid numer, IWłaściciel właściciel, IBank bank, decimal saldo):base(numer, właściciel, bank)
        {
        }



        new public decimal Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if(value < 0)
                {
                    throw new InvalidOperationException();
                }
                _saldo = value;
            }
        }

        public IRachunek RachunekPowiazany
        {
            get
            {
                return _rachunek;
            }
            set
            {
                _rachunek = value;
            }
        }
    }
}
