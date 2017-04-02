using NajlepszyBankSA.Interfejsy;
using NajlepszyBankSA.Interfejsy.Ograniczające;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NajlepszyBankSA
{
    public class HistoriaOperacji : IHistoriaOperacji
    {
        protected List<ILogOperacji> _opeacje;

        public ICollection<ILogOperacji> Operacje
        {
            get
            {
                return _opeacje;
            }
        }

        public HistoriaOperacji()
        {
            _opeacje = new List<ILogOperacji>();
        }
    }
}
