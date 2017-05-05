using NajlepszyBankSA.Interfejsy;
using NajlepszyBankSA.Interfejsy.Operacje;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NajlepszyBankSA.Operacje
{
    class ZwrotPrzelewuMiędzybankowego : IPrzelew, IOperacjaMiędzybankowa
    {
        protected IRachunek _rachunekDocelowy;
        protected IRachunek _rachunekWykonujący;
        protected decimal _kwota;
        protected DateTime _dataOperacji;
        protected IBank _bankWykonujący;
        protected IBank _bankDocelowy;

        IProdukt IOperacjaBankowa.RachunekWykonujący
        {
            get
            {
                return _rachunekWykonujący;
            }

            set
            {
                _rachunekWykonujący = (IRachunek)value;
            }
        }
        public IRachunek RachunekWykonujący
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

        public IRachunek RachunekDocelowy
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
                //return string.Format("Dnia {0} dokonano przelewu z {1} na {2} na kwotę {3}", _dataOperacji, _rachunekWykonujący.Numer, RachunekDocelowy.Numer, _kwota);
                return $"Dnia {_dataOperacji} dokonano zwrotu z {RachunekDocelowy.Numer} na {RachunekWykonujący.Numer} na kwotę {_kwota}";
            }
        }

        public IBank BankNadawcy
        {
            get
            {
                return _bankWykonujący;
            }

            set
            {
                _bankWykonujący = value;
            }
        }

        public IBank BankOdbiorcy
        {
            get
            {
                return _bankDocelowy;
            }

            set
            {
                _bankDocelowy = value;
            }
        }

        public ZwrotPrzelewuMiędzybankowego(IRachunek rachunekZNieprawidłowościami, IRachunek rachunekInicjujący, decimal kwota)
        {
            _rachunekDocelowy = rachunekInicjujący;
            _rachunekWykonujący = rachunekZNieprawidłowościami;
            _kwota = kwota;
            _bankDocelowy = _rachunekDocelowy.Bank;
            _bankWykonujący = _rachunekWykonujący.Bank;
        }


        private bool wykonana = false;

        public bool Wykonaj()
        {
            if (!wykonana)
            {
                try
                {
                    _dataOperacji = DateTime.Now;
                    _rachunekDocelowy.Wplac(_kwota);
                }
                catch
                {
                    return false;
                }
                wykonana = true;
                return true;
            }
            return false;
        }

        public void accept(IVisitor visitor)
        {
            throw new NotImplementedException();
        }
    }
}
