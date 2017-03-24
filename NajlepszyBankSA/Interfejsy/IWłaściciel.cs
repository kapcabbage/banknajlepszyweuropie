using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NajlepszyBankSA.Interfejsy
{
    public interface IWłaściciel
    {
        string Miasto
        {
            get;
            set;
        }

        string Ulica
        {
            get;
            set;
        }

        string NumerDomu
        {
            get;
            set;
        }

        string NumerLokalu
        {
            get;
            set;
        }

        string KodPocztowy
        {
            get;
            set;
        }

        string Nazwa
        {
            get;
        }

        string PełenAdres
        {
            get;
        }
    }
}
