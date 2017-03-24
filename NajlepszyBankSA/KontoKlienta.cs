using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NajlepszyBankSA
{
    public class KontoKlienta
    {
        protected static int GlobalIdKonta = 1;

        protected int IdKonta { get; set; }
        protected Osoba Klient { get; set; }

        protected List<Produkt> Produkty { get; set; }
        

        public KontoKlienta(Osoba Klient)
        {
            this.Klient = Klient;
            this.IdKonta = ++GlobalIdKonta;

        }
    }
}
