using NajlepszyBankSA.Interfejsy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NajlepszyBankSA
{
    public abstract class BazowyMechanizmOdsetkowy : IMechanizmOdsetkowy
    {
        protected DateTime _ostatnieNaliczenie;
        protected IProdukt _rachunek;
        private decimal _procent;

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

        public BazowyMechanizmOdsetkowy(IProdukt rachunek)
        {
            _rachunek = rachunek;
        }

        public void Nalicz()
        {
            _ostatnieNaliczenie = DateTime.Now;
            this._procent = this.ObliczProcent();
            _rachunek.Saldo += (_procent/100) * _rachunek.Saldo;
        }


        protected abstract decimal ObliczProcent();

    }
}
