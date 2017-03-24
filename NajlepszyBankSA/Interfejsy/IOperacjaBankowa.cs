using NajlepszyBankSA.Interfejsy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NajlepszyBankSA
{
    public interface IOperacjaBankowa
    {
        IRachunek RachunekWykonujący
        {
            get;
            set;
        }

        DateTime DataOperacji
        {
            get;
            set;
        }

        String Opis
        {
            get;
            set;
        }
    }
}
