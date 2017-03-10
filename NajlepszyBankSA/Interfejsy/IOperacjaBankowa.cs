using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NajlepszyBankSA
{
    public interface IOperacjaBankowa
    {
        LogOperacji StworzLog();

        void Wykonaj();
    }
}
