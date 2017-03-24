using NajlepszyBankSA.Interfejsy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NajlepszyBankSA
{
    public class Produkt : IProdukt
    {
        protected string _numer;
        protected decimal _saldo;
        protected DateTime _dataZałożenia;
        protected IWłaściciel _właściciel;
        protected IBank _bank;

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

        public string Numer
        {
            get
            {
                return _numer;
            }

            set
            {
                _numer = value;
            }
        }

        protected DateTime DataZałożenia { get; set; }

        protected HistoriaOperacji Historia { get; set; }

        public IWłaściciel Właściciel
        {
            get
            {
                return _właściciel;
            }

            set
            {
                _właściciel = value;
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

        public Produkt(string numer, IWłaściciel właściciel, IBank bank)
        {
            _numer = numer;
            _właściciel = właściciel;
            _bank = bank;

            _dataZałożenia = DateTime.Now;
            Historia = new HistoriaOperacji();
        }
        
    }
}
