using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QWFramework.IntegralsType
{
    public class Dxa2x2Integral : IIntegralClass
    {
        public string ReturnAnswer(List<int> argument, string addon)
        {
            return addon + $"1/{argument[0]}*artcg(x/{argument[0]})+c";
        }
    }
}
