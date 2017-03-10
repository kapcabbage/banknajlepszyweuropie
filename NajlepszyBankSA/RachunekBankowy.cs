using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NajlepszyBankSA
{
    public class RachunekBankowy : Rachunek
    {
        private decimal Debet { get; set; }


        public RachunekBankowy() : base() 
        {
            this.Debet = 0;
        }

    }
}
