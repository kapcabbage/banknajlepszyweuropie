using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NajlepszyBankSA
{
    public class HistoriaOperacji
    {
        private List<LogOperacji> _opeacje;

        public List<LogOperacji> Operacje
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
            _opeacje = new List<LogOperacji>();
        }
    }
}
