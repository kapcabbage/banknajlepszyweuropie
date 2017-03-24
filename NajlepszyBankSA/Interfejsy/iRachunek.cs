﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NajlepszyBankSA.Interfejsy
{
    public interface IRachunek:IProdukt
    {
        string Numer
        {
            get;
            set;
        }
        decimal DopuszczalnyDebet
        {
            get;
            set;
        }
    }
}
