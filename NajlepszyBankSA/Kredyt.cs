using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NajlepszyBankSA
{
    public class Kredyt : Rachunek
    {
        private RachunekBankowy RachunekBankowy { get; set; }

        public Kredyt(RachunekBankowy RachunekPowiazany) : base()
        {
            this.RachunekBankowy = RachunekPowiazany;
        }
    }
}
