using NajlepszyBankSA.Interfejsy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NajlepszyBankSA
{
    public class Rachunek : IRachunek
    {
        private string _numer;
        private decimal _saldo;
        private Osoba _właściciel;
        private Bank _bankPowiązany;

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

        protected DateTime DataZalozenia { get; set; }

        protected MechanizmOdsetkowy MechanizmOdsetkowy { get; set; }

        protected HistoriaOperacji Historia { get; set; }

        public IWłaściciel Właściciel
        {
            get
            {
                return _właściciel;
            }

            set
            {
                _właściciel = (Osoba)value;
            }
        }

        public IBank BankPowiązany
        {
            get
            {
                return _bankPowiązany;
            }

            set
            {
                _bankPowiązany = (Bank)value;
            }
        }

        public Rachunek()
        {
            this.Saldo = 0;
            this.DataZalozenia = DateTime.Now;
            this.MechanizmOdsetkowy = new MechanizmOdsetkowy();
            this.Historia = new HistoriaOperacji();

        }
        
    }
}
