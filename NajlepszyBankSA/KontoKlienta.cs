using NajlepszyBankSA.Interfejsy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NajlepszyBankSA
{
    public class KontoKlienta : IKontoKlienta
    {
        protected Guid _ID;
        protected IWłaściciel _właściciel;
        protected List<IProdukt> _produkty;

        public Guid ID
        {
            get
            {
                return _ID;
            }
            set
            {
                _ID = value;
            }
        }
    
        public IWłaściciel Właściciel
        {
            get
            {
                return _właściciel;
            }
            set
            {
                _właściciel = value;
            }
        }

        public ICollection<IProdukt> Produkty
        {
            get
            {
                return _produkty;
            }
        }
        

        public KontoKlienta(Guid ID, IWłaściciel właściciel)
        {
            _ID = ID;
            _właściciel = właściciel;
            _produkty = new List<IProdukt>();
        }
    }
}
