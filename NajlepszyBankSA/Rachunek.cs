﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NajlepszyBankSA
{
    public class Rachunek
    {
        protected ulong IdRachunku { get; set; }

        protected decimal Saldo { get; set; }

        protected DateTime DataZalozenia { get; set; }

        protected MechanizmOdsetkowy MechanizmOdsetkowy { get; set; }

        protected HistoriaOperacji Historia { get; set; }
    }
}
