using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NajlepszyBankSA.Interfejsy
{
    public interface IOsoba : IWłaściciel
    {
        string Imie
        {
            get;
            set;
        }

        string Nazwisko
        {
            get;
            set;
        }

        string PESEL
        {
            get;
            set;
        }
    }
}
