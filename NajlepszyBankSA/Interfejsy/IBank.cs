using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NajlepszyBankSA.Interfejsy
{
    public interface IBank
    {
        void Wykonaj(IOperacjaBankowa operacja);

        void NadajPrzelewMiędzybankowy(IPrzelew podstawa);

        void NadajZwrotPrzelewuMiędzybankowego(IPrzelew nieprawidłowyPrzelew);

        IEnumerable<IKontoKlienta> kontaKlienta
        {
            get;
        }
    }
}
