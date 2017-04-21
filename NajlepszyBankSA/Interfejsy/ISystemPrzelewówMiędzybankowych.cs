using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NajlepszyBankSA.Interfejsy
{
    public interface ISystemPrzelewówMiędzybankowych
    {
        void WykonajWiele(ICollection<IPrzelew> lista);
        void WykonajJeden(IPrzelew przelew);
        void ZarejestrujBank(IBank bank);

    }
}
