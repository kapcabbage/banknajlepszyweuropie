using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NajlepszyBankSA.Interfejsy;

namespace NajlepszyBankSA
{
    public class SplataKredytu : ISplataKredytu
    {
        protected DateTime _dataOperacji;
        protected decimal _kwota;
        protected IKredyt _kredyt;
        

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
                return string.Format("Dnia {0} dokonano splaty kredytu z {1} na kwotę {2}", _dataOperacji, _kredyt.RachunekPowiazany.Numer, _kwota);
            }
        }

        public IProdukt RachunekWykonujący
        {
            get
            {
                return _kredyt;
            }

            set
            {
                _kredyt = (IKredyt)value;
            }
        }

        public bool Wykonaj()
        {
            try
            {
                _dataOperacji = DateTime.Now;
                _kredyt.RachunekPowiazany.Saldo -= _kwota;
                _kredyt.Saldo -= _kwota;
                return true;
            }
            catch
            {
                //TODO
            }
            return false;
        }
    }
}
