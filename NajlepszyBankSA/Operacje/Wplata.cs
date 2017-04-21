using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NajlepszyBankSA.Interfejsy;

namespace NajlepszyBankSA
{
    public class Wplata: IWplata
    {
        protected decimal _kwota;
        protected DateTime _dataOperacji;
        protected string _opis;
        protected IRachunek _rachunekWykonujacy;

        IProdukt IOperacjaBankowa.RachunekWykonujący
        {
            get
            {
                return _rachunekWykonujacy;
            }

            set
            {
                _rachunekWykonujacy = (IRachunek) value;
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

        public string Opis
        {
            get
            {
                return string.Format("Dnia {0} dokonano wplaty z {1} na kwotę {2}", _dataOperacji, _rachunekWykonujacy.Numer, _kwota);
            }
        }

        public IRachunek RachunekWykonujący
        {
            get
            {
                return _rachunekWykonujacy;
            }

            set
            {
                _rachunekWykonujacy = value;
            }
        }

        public Wplata(IRachunek rachunekWykonujacy, decimal kwota)
        {
            _rachunekWykonujacy = rachunekWykonujacy;
            _kwota = kwota;
        }

        private bool wykonana = false;

        public bool Wykonaj()
        {
            if (!wykonana)
            {
                wykonana = true;
                try
                {
                    _dataOperacji = DateTime.Now;
                    _rachunekWykonujacy.Wplac(_kwota);
                    //_rachunekWykonujacy.__Saldo += _kwota;
                    return true;
                }
                catch
                {
                    //TODO
                }
                return false;
            }
            return false;
        }
    }
}
