using NajlepszyBankSA.Interfejsy.Ograniczające;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NajlepszyBankSA
{
    public class HistoriaOperacji
    {
        protected List<ILogOperacji> _opeacje;

        public List<ILogOperacji> Operacje
        {
            get
            {
                return _opeacje;
            }
            set
            {
                _opeacje = value;
            }
        }

        public HistoriaOperacji()
        {
            _opeacje = new List<ILogOperacji>();
        }
    }
}
