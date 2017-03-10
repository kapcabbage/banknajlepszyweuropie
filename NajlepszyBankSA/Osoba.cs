using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NajlepszyBankSA
{
    public class Osoba
    {
        private string Imie {get;set;}

        private string Nazwisko { get; set; }


        public Osoba(string Imie, string Nazwisko)
        {
            this.Imie = Imie;
            this.Nazwisko = Nazwisko;
        }
    }
}
