using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NajlepszyBankSA
{
    public class Lokata : Rachunek
    {
        private decimal Oprocentowanie
        {
            get
            {
                return 2;
            }
        }

        public Lokata() : base()
        {

        }
    }
}
