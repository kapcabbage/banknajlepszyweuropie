using NajlepszyBankSA.Interfejsy;
using NajlepszyBankSA.Interfejsy.Operacje;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NajlepszyBankSA
{
    public class SystemPrzelewówMiędzybankowych : ISystemPrzelewówMiędzybankowych
    {
        protected List<IBank> _banki;

        public void WykonajJeden(IOperacjaMiędzybankowa operacja)
        {
            operacja.BankNadawcy.Wykonaj((IOperacjaBankowa)operacja);
        }

        public void WykonajWiele(ICollection<IOperacjaMiędzybankowa> lista)
        {
            foreach(IOperacjaMiędzybankowa operacja in lista)
            {
                operacja.BankNadawcy.Wykonaj((IOperacjaBankowa)operacja);
            }
        }

        public void ZarejestrujBank(IBank bank)
        {
            _banki.Add(bank);
        }
    }
}
