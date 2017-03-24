using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NajlepszyBankSA.Interfejsy
{
    public interface ISplataKredytu : IOperacjaBankowa
    {
        IRachunek rachunek
        {
            get;set;
        }
        decimal Kwota
        {
            get; set;
        }
    }
}
