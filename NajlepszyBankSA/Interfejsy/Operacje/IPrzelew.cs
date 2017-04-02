using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NajlepszyBankSA.Interfejsy
{
    public interface IPrzelew : IOperacjaBankowa
    {
        new IRachunek RachunekWykonujący
        {
            get;set;
        }

        IRachunek RachunekDocelowy
        {
            get;
            set;
        }

        decimal Kwota
        {
            get;
            set;
        }
    }
}
