using NajlepszyBankSA.Interfejsy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NajlepszyBankSA.Produkty
{
    class RachunekDebetowy: Produkt, IRachunek
    {
        private IRachunek _rachunek;
        private decimal _dopuszczalnyDebet;
        private decimal _debet;

        public RachunekDebetowy(Guid numer, IWłaściciel właściciel, IBank bank, IRachunek rachunek) : base(numer, właściciel, bank)
        {
            this._rachunek = rachunek;
        }


        public void Wplac(decimal kwota)
        {
            decimal stanDebetu = this._debet;

            if (stanDebetu > 0)
                this._debet -= kwota;

            decimal nadwyzka = Math.Abs(stanDebetu - kwota);

            this._saldo += nadwyzka;
        }

        public void Pobierz(decimal kwota)
        {
            if(kwota > this._saldo + this._dopuszczalnyDebet)
                throw new InvalidOperationException("Żądana kwota wypłaty przekracza stan salda.");
            else if (kwota > _saldo)
            {
                this._saldo = 0;
                this._debet += kwota - this._saldo;
            }
            else
            {
                this._saldo -= kwota;
            }

        }


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

        public IMechanizmOdsetkowy MechanizmOdsetkowy
        {
            get
            {
                return this._rachunek.MechanizmOdsetkowy;
            }

            set
            {
                this._rachunek.MechanizmOdsetkowy = value;
            }
        }
    }
}
