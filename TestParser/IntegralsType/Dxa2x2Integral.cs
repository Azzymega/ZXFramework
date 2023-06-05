using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QWFramework.Core;

namespace QWFramework.IntegralsType
{
    public class Dxa2x2Integral : IIntegralClass
    {
        public string ReturnAnswer(List<int> argument, string addon)
        {
            if (addon == "")
            {
                return $"(1/{argument[0]})*artcg(x/{argument[0]})+c";
            }
            if (addon.IndexOf('/') != -1)
            {
                string[] arguments = addon.Split('/');
                arguments[1] = arguments[1].Trim('*');
                return $"({float.Parse(arguments[0]) / (argument[0] * float.Parse(arguments[1]))})*artcg(x/{argument[0]})+c";
            }
            if (int.Parse(addon.TrimEnd('*')) % argument[0] == 0)
            {
                return $"({int.Parse(addon.TrimEnd('*'))/argument[0]})*artcg(x/{argument[0]})+c";
            }
            addon = addon.Trim('*');
            return $"({addon}/{argument[0]})*artcg(x/{argument[0]})+c";
        }
    }
}
