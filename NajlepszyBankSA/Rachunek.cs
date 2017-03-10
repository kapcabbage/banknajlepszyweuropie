using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NajlepszyBankSA
{
    class Rachunek
    {
        protected ulong NumerRachunku { get; set; }

        protected DateTime DataZalozenia { get; set; }

        protected MechanizmOdsetkowy MechanizmOdsetkowy { get; set; }
    }
}
