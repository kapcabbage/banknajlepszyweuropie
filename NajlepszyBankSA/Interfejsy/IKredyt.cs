﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NajlepszyBankSA.Interfejsy
{
    public interface IKredyt : IProdukt
    {
        IRachunek RachunekPowiazany
        {
            get;set;
        }
    }
}
