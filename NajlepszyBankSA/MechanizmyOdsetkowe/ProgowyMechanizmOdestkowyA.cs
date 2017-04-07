using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NajlepszyBankSA.Interfejsy;

namespace NajlepszyBankSA.MechanizmyOdsetkowe
{
    public class ProgowyMechanizmOdestkowyA: BazowyMechanizmOdsetkowy
    {
        private readonly int _PROG1 = 1000;
        private readonly int _PROG2 = 5000;

        public ProgowyMechanizmOdestkowyA(IProdukt rachunek) : base(rachunek)
        {
        }

        protected override decimal ObliczProcent()
        {
            decimal procent = 0;

            if (_rachunek.Saldo < _PROG1)
                procent = 1;
            else if (_rachunek.Saldo >= _PROG1 && _rachunek.Saldo < _PROG2)
                procent = 2;
            else if (_rachunek.Saldo >= _PROG2)
                procent = 3;

            return procent;
        }
    }
}
