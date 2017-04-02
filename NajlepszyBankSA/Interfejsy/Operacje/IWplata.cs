using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NajlepszyBankSA.Interfejsy
{
    public interface IWplata : IOperacjaBankowa
    {
        decimal Kwota
        {
            get;set;
        }
    }
}
