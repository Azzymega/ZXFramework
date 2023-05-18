﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QWFramework.IntegralsType
{
    public class SinaxdxIntegral : IIntegralClass
    {
        public string ReturnAnswer(int argument)
        {
            return $"-1/{argument}*cos({argument}x)+c";
        }
    }
}