using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QWFramework.Core;

namespace QWFramework.IntegralsType
{
    public class Dxx2a2Integral : IIntegralClass
    {
        public string ReturnAnswer(List<int> argument, string addon)
        {
            argument[1] *= -1;
            if (addon == "")
            {
                return $"(1/{argument[1]*2*-1})*ln((x-{argument[1] * -1})/(x+{argument[1] * -1}))+c";
            }
            if (addon.IndexOf('/') != -1)
            {
                string[] arguments = addon.Split('/');
                arguments[1] = arguments[1].Trim('*');
                if (int.Parse(arguments[0]) % (argument[1] * 2 * -1 * int.Parse(arguments[1])) != 0)
                {
                    return $"({arguments[0]}/{argument[1] * 2 * -1 * int.Parse(arguments[1])})*ln((x-{argument[1] * -1})/(x+{argument[1] * -1}))+c";
                }
                return $"({int.Parse(arguments[0]) / argument[1] * 2 * -1 * int.Parse(arguments[1])})*ln((x-{argument[1] * -1})/(x+{argument[1] * -1}))+c";
            }
            return $"{float.Parse(addon.Trim('*')) / (argument[1]*2*-1)}*ln((x-{argument[1] * -1})/(x+{argument[1] * -1}))+c";
        }
    }
}
