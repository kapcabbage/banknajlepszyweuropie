using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NajlepszyBankSA.Interfejsy
{
    interface IRachunek:IProdukt
    {
        decimal DopuszczalnyDebet
        {
            get;
            set;
        }
    }
}
