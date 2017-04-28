using NajlepszyBankSA.Interfejsy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NajlepszyBankSA.Odwiedzajacy
{
    public class ReportVisitor : IVisitor
    {
        private string RaportPrzelewu;
        private string RaportWplat;
        private string RaportWyplat;
        private string RaportSplatKredytu;
        public void visit(IPrzelew przelew)
        {
            RaportPrzelewu = przelew.Opis;
        }
        public void visit(IWplata wplata)
        {
            RaportWplat = wplata.Opis;
        }
        public void visit(IWyplata wyplata)
        {
            RaportWyplat = wyplata.Opis;
        }
        public void visit(ISplataKredytu splata)
        {
            RaportSplatKredytu = splata.Opis;
        }
    }
}
