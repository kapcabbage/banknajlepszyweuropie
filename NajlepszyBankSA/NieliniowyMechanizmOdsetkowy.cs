using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NajlepszyBankSA.Interfejsy;

namespace NajlepszyBankSA
{
    public class NieliniowyMechanizmOdsetkowy : IMechanizmOdsetkowy
    {
        protected DateTime _ostatnieNaliczenie;
        protected IProdukt _rachunek;
        protected decimal _procent;

        public DateTime OstatnieNaliczenie
        {
            get
            {
                return _ostatnieNaliczenie;
            }

            set
            {
                _ostatnieNaliczenie = value;
            }
        }

        public NieliniowyMechanizmOdsetkowy(IProdukt rachunek, decimal procent)
        {
            _rachunek = rachunek;
            _procent = procent;
        }

        public void Nalicz()
        {
            _ostatnieNaliczenie = DateTime.Now;
            _rachunek.Saldo += (_procent / 100) * _rachunek.Saldo;
        }
    }
}
