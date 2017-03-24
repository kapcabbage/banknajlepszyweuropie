using NajlepszyBankSA.Interfejsy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NajlepszyBankSA
{
    public class Przelew : IPrzelew
    {
        private IRachunek _rachunekDocelowy;
        private IRachunek _rachunekWykonujący;
        private decimal _kwota;

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

        public DateTime DataOperacji
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public string Opis
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public Przelew(Rachunek rachunekZ, Rachunek rachunekNa, decimal kwota)
        {
            _rachunekDocelowy = rachunekNa;
            _rachunekWykonujący = rachunekZ;
            _kwota = kwota;
        }

        public LogOperacji StworzLog()
        {
            LogOperacji logOperacji = new LogOperacji();
            logOperacji.Data = DateTime.Now;
            logOperacji.Opis = string.Format("Wykonano przelew z {0} do {1} na kwotę {2}");

            return logOperacji;
        }
    }
}
