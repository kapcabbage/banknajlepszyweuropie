﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NajlepszyBankSA.Interfejsy;

namespace NajlepszyBankSA
{
    public class NieliniowyMechanizmOdsetkowy : BazowyMechanizmOdsetkowy
    {
       public NieliniowyMechanizmOdsetkowy(IProdukt rachunek, decimal procent) : base (rachunek,procent)
       {

       }

        protected override void ObliczProcent()
        {
            
        }

    }
}
