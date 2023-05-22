using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QWFramework.IntegralsType
{
    public class Dxx2a2Integral : IIntegralClass
    {
        public string ReturnAnswer(List<int> argument, string addon)
        {
            argument[1] *= -1;
            return addon + $"1/{argument[1] * 2 * -1}*ln((x-{argument[1] * -1})/(x+{argument[1] * -1}))+c";
        }
    }
}
