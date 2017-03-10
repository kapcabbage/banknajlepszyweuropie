using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NajlepszyBankSA
{
    public class Przelew : IOperacjaBankowa
    {
        private Rachunek _rachunekZ;
        private Rachunek _rachunekNa;
        private decimal _kwota;

        public Przelew(Rachunek rachunekZ, Rachunek rachunekNa, decimal kwota)
        {
            _rachunekNa = rachunekNa;
            _rachunekZ = rachunekZ;
            _kwota = kwota;
        }

        public LogOperacji StworzLog()
        {
            LogOperacji logOperacji = new LogOperacji();
            logOperacji.Data = DateTime.Now;
            logOperacji.Opis = string.Format("Wykonano przelew z {0} do {1} na kwotę {2}");

            return logOperacji;
        }
    }
}
