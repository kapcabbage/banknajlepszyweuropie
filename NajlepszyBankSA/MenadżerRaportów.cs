using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NajlepszyBankSA
{
    public class MenadżerRaportów
    {
        private HistoriaOperacji _historia; 
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
