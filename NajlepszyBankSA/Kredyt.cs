using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NajlepszyBankSA.Interfejsy;

namespace NajlepszyBankSA
{
    public class Kredyt : IKredyt
    {
        protected IRachunek _rachunek;
        protected IBank _bank;
        protected decimal _saldo;
        protected IWłaściciel _wlasciciel;


        public IRachunek RachunekPowiazany
        {
            get
            {
                return _rachunek;
            }
            set
            {
                _rachunek = value;
            }
        }
        public IBank Bank
        {
            get
            {
                return _bank;
            }

            set
            {
                _bank = value;
            }
        }

        public decimal Saldo
        {
            get
            {
                return _saldo;
            }

            set
            {
                _saldo = value;
            }
        }

        public IWłaściciel Właściciel
        {
            get
            {
                return _wlasciciel;
            }

            set
            {
                _wlasciciel = value;
            }
        }
    }
}
