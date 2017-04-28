using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NajlepszyBankSA.Interfejsy
{
    public interface IVisitor
    {
        void visit(IPrzelew przelew);

        void visit(IWplata przelew);

        void visit(IWyplata przelew);

        void visit(ISplataKredytu przelew);


    }
}
