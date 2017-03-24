using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NajlepszyBankSA.Interfejsy
{
    public interface ILokata: IProdukt
    {

        string Numer
        {
            get;
            set;
        }

        IMechanizmOdsetkowy mechanizmOdsetkowy
        {
            get;
            set;
        }
    }
}
