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
        protected Guid _numer;
        protected decimal _saldo;
        protected DateTime _dataZałożenia;
        protected HistoriaOperacji _historia;

        protected IWłaściciel _właściciel;
        protected IBank _bank;

        public decimal __Saldo
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

        public Guid Numer
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

        public DateTime DataZałożenia
        {
            get
            {
                return _dataZałożenia;
            }
            set
            {
                _dataZałożenia = value;
            }
        }

        public IHistoriaOperacji Historia
        {
            get
            {
                return _historia;
            }
        }

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

        public Produkt(Guid numer, IWłaściciel właściciel, IBank bank)
        {
            _numer = numer;
            _właściciel = właściciel;
            _bank = bank;

            _dataZałożenia = DateTime.Now;
            _historia = new HistoriaOperacji();
        }

        public void WykonajOperacje(IOperacjaBankowa Operacja)
        {
            Operacja.Wykonaj();
        }
        
    }
}
