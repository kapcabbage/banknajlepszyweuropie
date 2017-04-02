using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NajlepszyBankSA.Interfejsy
{
    public interface IRachunek:IProdukt
    {
        Guid Numer
        {
            get;
            set;
        }
        decimal DopuszczalnyDebet
        {
            get;
            set;
        }
    }
}
