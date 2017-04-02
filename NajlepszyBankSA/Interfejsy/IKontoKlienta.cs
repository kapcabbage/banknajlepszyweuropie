using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NajlepszyBankSA.Interfejsy
{
    public interface IKontoKlienta
    {
        Guid ID
        {
            get;
            set;
        }

        IWłaściciel Właściciel
        {
            get;
            set;
        }

        ICollection<IProdukt> Produkty
        {
            get;
        }
    }
}
