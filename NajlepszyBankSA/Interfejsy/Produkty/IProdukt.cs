using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NajlepszyBankSA.Interfejsy
{
    public interface IProdukt
    {

        decimal __Saldo
        {
            get;
            set;
        }

        IWłaściciel Właściciel
        {
            get;
            set;
        }

        IBank Bank
        {
            get;
            set;
        }

        IHistoriaOperacji Historia
        {
            get;
        }
    }
}
