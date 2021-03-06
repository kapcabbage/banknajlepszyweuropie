﻿using NajlepszyBankSA.Interfejsy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NajlepszyBankSA
{
    public class Przelew : IPrzelew
    {
        protected IRachunek _rachunekDocelowy;
        protected IRachunek _rachunekWykonujący;
        protected decimal _kwota;
        protected DateTime _dataOperacji;


        public void accept(IVisitor visitor)
        {
            visitor.visit(this);
        }

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
                return string.Format("Dnia {0} dokonano przelewu z {1} na {2} na kwotę {3}", _dataOperacji, _rachunekWykonujący.Numer, RachunekDocelowy.Numer, _kwota);
            }
        }

        public Przelew(Rachunek rachunekZ, Rachunek rachunekNa, decimal kwota)
        {
            _rachunekDocelowy = rachunekNa;
            _rachunekWykonujący = rachunekZ;
            _kwota = kwota;
        }


        private bool wykonana = false;

        public bool Wykonaj()
        {
            if (!wykonana)
            {
                if(_rachunekDocelowy.Bank != _rachunekWykonujący.Bank)
                {
                    _rachunekWykonujący.Bank.NadajPrzelewMiędzybankowy(this);
                }
                try
                {
                    _dataOperacji = DateTime.Now;
                    _rachunekWykonujący.Pobierz( _kwota);
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


    }
}
