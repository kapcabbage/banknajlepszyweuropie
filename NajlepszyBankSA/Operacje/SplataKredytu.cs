using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NajlepszyBankSA.Interfejsy;

namespace NajlepszyBankSA
{
    public class SplataKredytu: ISplataKredytu
    {
        protected DateTime _dataOperacji;
        protected decimal _kwota;
        protected IKredyt _kredyt;

        public SplataKredytu(IKredyt kredyt, decimal kwota)
        {
            _kredyt = kredyt;
            _kwota = kwota;
        }

        public void accept(IVisitor visitor)
        {
            visitor.visit(this);
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
                _kredyt = (IKredyt) value;
            }
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
                    _kredyt.RachunekPowiazany.Pobierz(_kwota);
                    _kredyt.__Saldo -= _kwota;
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
