using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QWFramework.Core;

namespace QWFramework.IntegralsType
{
    public class SinaxdxIntegral : IIntegralClass
    {
        public string ReturnAnswer(List<int> argument, string addon)
        {
            if (addon == "")
            {
                return $"-(1/{argument[0]})*cos({argument[0]}x)+c";
            }
            if (addon.IndexOf('/') != -1)
            {
                string[] arguments = addon.Split('/');
                arguments[1] = arguments[1].Trim('*');
                return $"-({float.Parse(arguments[0]) / (float)(argument[0] * int.Parse(arguments[1]))})*cos({argument[0]})+c";
            }
            if (int.Parse(addon.TrimEnd('*')) % argument[0] == 0)
            {
                if (int.Parse(addon.TrimEnd('*')) / argument[0] == 1)
                {
                    return $"-cos({argument[0]})+c";
                }
                return $"-({1 * int.Parse(addon.TrimEnd('*')) / argument[0]})*cos({argument[0]})+c";
            }
            return $"-({1 * int.Parse(addon.TrimEnd('*'))}/{argument[0]})*cos({argument[0]}x)+c";
        }
    }
}
