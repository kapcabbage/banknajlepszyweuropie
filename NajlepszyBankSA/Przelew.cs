using NajlepszyBankSA.Interfejsy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NajlepszyBankSA
{
    public class Przelew : IPrzelew
    {
        protected IProdukt _rachunekDocelowy;
        protected IProdukt _rachunekWykonujący;
        protected decimal _kwota;
        protected DateTime _dataOperacji;

        public IProdukt RachunekWykonujący
        {
            get
            {
                return _rachunekWykonujący;
            }

            set
            {
                _rachunekWykonujący = value;
            }
        }

        public IProdukt RachunekDocelowy
        {
            get
            {
                return _rachunekDocelowy;
            }

            set
            {
                _rachunekDocelowy = value;
            }
        }

        public decimal Kwota
        {
            get
            {
                return _kwota;
            }

            set
            {
                _kwota = value;
            }
        }


        public DateTime DataOperacji
        {
            get
            {
                return _dataOperacji;
            }

            set
            {
                _dataOperacji = value;
            }
        }

        public string Opis
        {
            get
            {
                return string.Format("Dnia {0} dokonano przelewu z {1} na {2} na kwotę {3}", _dataOperacji, _rachunekWykonujący.Numer, RachunekDocelowy.Numer, _kwota);
            }
        }

        public Przelew(Produkt rachunekZ, Produkt rachunekNa, decimal kwota)
        {
            _rachunekDocelowy = rachunekNa;
            _rachunekWykonujący = rachunekZ;
            _kwota = kwota;
        }

        public bool Wykonaj()
        {
            try
            {
                _rachunekWykonujący.Saldo -= _kwota;
                _rachunekDocelowy.Saldo += _kwota;
            }
            catch
            {
                return false;
            }

            return true;
        }
    }
}
