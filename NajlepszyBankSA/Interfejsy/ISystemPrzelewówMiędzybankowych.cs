using NajlepszyBankSA.Interfejsy.Operacje;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NajlepszyBankSA.Interfejsy
{
    public interface ISystemPrzelewówMiędzybankowych
    {
        void WykonajWiele(ICollection<IOperacjaMiędzybankowa> lista);
        void WykonajJeden(IOperacjaMiędzybankowa przelew);
        void ZarejestrujBank(IBank bank);

    }
}
