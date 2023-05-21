using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QWFramework.IntegralsType
{
    public class CosaxdxIntegral : IIntegralClass
    {
        public string ReturnAnswer(int argument, string addon)
        {
            return $"1/{argument}*sin({argument}x)+c";
        }
    }
}
