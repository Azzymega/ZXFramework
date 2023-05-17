using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QWFramework.IntegralsType
{
    public class Dxa2x2Integral : IIntegralClass
    {
        public string ReturnAnswer(int argument)
        {
            return $"1/{argument}*artcg(x/{argument})+c";
        }
    }
}
