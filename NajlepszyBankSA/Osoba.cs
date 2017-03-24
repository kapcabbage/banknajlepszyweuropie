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
        protected string _imie;
        protected string _nazwisko;
        protected string _pesel;
        protected string _miesto;
        protected string _ulica;
        protected string _numerDomu;
        protected string _numerLokalu;
        protected string _kodPocztowy;

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
                return _nazwisko;
            }

            set
            {
                _nazwisko = value;
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
                return String.Format("{0} {1}", _imie, _nazwisko);
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
            _imie = imie;
            _nazwisko = nazwisko;
            _pesel = pesel;
        }
    }
}
