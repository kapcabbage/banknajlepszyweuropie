using NajlepszyBankSA.Interfejsy.Ograniczające;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NajlepszyBankSA.Interfejsy
{
    public interface IHistoriaOperacji
    {
        List<ILogOperacji> Operacje
        {
            get; set;
        }

    }
}
