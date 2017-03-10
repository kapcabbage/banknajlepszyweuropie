using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NajlepszyBankSA
{
    public class KontoKlienta
    {
        private static int GlobalIdKonta = 1;

        private int IdKonta { get; set; }
        private Osoba Klient { get; set; }

        private List<Rachunek> Produkty { get; set; }
        

        public KontoKlienta(Osoba Klient)
        {
            this.Klient = Klient;
            this.IdKonta = ++GlobalIdKonta;

        }
    }
}
