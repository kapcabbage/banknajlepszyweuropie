using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NajlepszyBankSA.Interfejsy
{
    public interface IRachunek
    {
        string Numer
        {
            get;
            set;
        }

        decimal Saldo
        {
            get;
            set;
        }

        IWłaściciel Właściciel
        {
            get;
            set;
        }

        IBank BankPowiązany
        {
            get;
            set;
        }
    }
}
