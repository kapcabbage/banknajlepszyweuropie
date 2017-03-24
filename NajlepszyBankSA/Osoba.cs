using NajlepszyBankSA.Interfejsy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NajlepszyBankSA
{
    public class Osoba : IOsoba
    {
        private string _imie;
        private string _naziwsko;
        private string _pesel;
        private string _miesto;
        private string _ulica;
        private string _numerDomu;
        private string _numerLokalu;
        private string _kodPocztowy;

        public string Imie
        {
            get
            {
                return _imie;
            }

            set
            {
                _imie = value;
            }
        }

        public string Nazwisko
        {
            get
            {
                return _naziwsko;
            }

            set
            {
                _naziwsko = value;
            }
        }

        public string PESEL
        {
            get
            {
                return _pesel;
            }

            set
            {
                _pesel = value;
            }
        }

        public string Miasto
        {
            get
            {
                return _miesto;
            }

            set
            {
                _miesto = value;
            }
        }

        public string Ulica
        {
            get
            {
                return _ulica;
            }

            set
            {
                _ulica = value;
            }
        }

        public string NumerDomu
        {
            get
            {
                return _numerDomu;
            }

            set
            {
                _numerDomu = value;
            }
        }

        public string NumerLokalu
        {
            get
            {
                return _numerLokalu;
            }

            set
            {
                _numerLokalu = value;
            }
        }

        public string KodPocztowy
        {
            get
            {
                return _kodPocztowy;
            }

            set
            {
                _kodPocztowy = value;
            }
        }

        public string Nazwa
        {
            get
            {
                return String.Format("{0} {1}", _imie, _naziwsko);
            }
        }

        public string PełenAdres
        {
            get
            {
                return String.Format("{0} {1}/{2} {3} {4}", _ulica, _numerDomu, _numerLokalu, _kodPocztowy, _miesto);
            }
        }

        public Osoba(string imie, string nazwisko, string pesel)
        {
            this.Imie = Imie;
            this.Nazwisko = Nazwisko;
            this.PESEL = pesel;
        }
    }
}
