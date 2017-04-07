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

        public ProgowyMechanizmOdestkowyA(IProdukt rachunek, decimal procent) : base(rachunek, procent)
        {
        }

        protected override void ObliczProcent()
        {
            if (_rachunek.Saldo < _PROG1)
                _procent = 1;
            else if (_rachunek.Saldo >= _PROG1 && _rachunek.Saldo < _PROG2)
                _procent = 2;
            else if (_rachunek.Saldo >= _PROG2)
                _procent = 3;
        }
    }
}
