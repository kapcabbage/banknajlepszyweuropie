using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NajlepszyBankSA
{
    public class MenadżerRaportów
    {
        protected HistoriaOperacji _historia; 
        public MenadżerRaportów(HistoriaOperacji historia)
        {
            _historia = historia;
        }

        public string WykonarRaportGeneralny()
        {
            return string.Join("\n", _historia.Operacje);
        }
    }
}
