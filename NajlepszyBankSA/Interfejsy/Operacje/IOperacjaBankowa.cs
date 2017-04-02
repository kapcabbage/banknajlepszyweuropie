using NajlepszyBankSA.Interfejsy;
using NajlepszyBankSA.Interfejsy.Ograniczające;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NajlepszyBankSA
{
    public interface IOperacjaBankowa : ILogOperacji
    {
        IProdukt RachunekWykonujący
        {
            get;
            set;
        }

        DateTime DataOperacji
        {
            get;
            set;
        }

        new string Opis
        {
            get;
        }

        bool Wykonaj();
    }
}
