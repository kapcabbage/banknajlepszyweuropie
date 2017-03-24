using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NajlepszyBankSA.Interfejsy;

namespace NajlepszyBankSA
{
    public class Wyplata : IWyplata
    {

        protected decimal _kwota;
        protected DateTime _dataOperacji;
        protected string _opis;
        protected IProdukt _rachunekWykonujacy;

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
                return string.Format("Dnia {0} dokonano wyplaty z {1} na kwotę {2}", _dataOperacji, _rachunekWykonujacy.Numer, _kwota);
            }
        }

        public IProdukt RachunekWykonujący
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

        public Wyplata(IProdukt rachunekWykonujacy,decimal kwota)
        {
            _rachunekWykonujacy = rachunekWykonujacy;
            _kwota = kwota; 
        }

        public void Wykonaj()
        {
            try
            {
                _dataOperacji = DateTime.Now;
                _rachunekWykonujacy.Saldo -= _kwota;
            }
            catch
            {
                //TODO
            }
        }
    }
}
