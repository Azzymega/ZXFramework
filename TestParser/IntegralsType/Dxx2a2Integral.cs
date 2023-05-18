﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QWFramework.IntegralsType
{
    public class Dxx2a2Integral : IIntegralClass
    {
        public string ReturnAnswer(int argument)
        {
            argument *= -1;
            return $"1/{argument*2}*ln((x-{argument})/(x+{argument}))+c";
        }
    }
}
