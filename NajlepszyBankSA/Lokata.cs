﻿using NajlepszyBankSA.Interfejsy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NajlepszyBankSA
{
    public class Lokata : Produkt, ILokata
    {
        protected IMechanizmOdsetkowy _mechanizmOdsetkowy;
        

        public IMechanizmOdsetkowy MechanizmOdsetkowy {
            get
            {
                return _mechanizmOdsetkowy;
            }
            set
            {
                _mechanizmOdsetkowy = value;
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
                throw new InvalidOperationException("Nie można modyfikować bezpośrednio salda lokaty");
            }
        }


        public Lokata(string numer, IWłaściciel właściciel, IBank bank, decimal saldo) : base(numer, właściciel, bank)
        {
            _saldo = saldo;
        }
    }
}
