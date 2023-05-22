using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QWFramework.IntegralsType
{
    public class CosaxdxIntegral : IIntegralClass
    {
        public string ReturnAnswer(List<int> argument, string addon)
        {
            return addon+$"1/{argument[0]}*sin({argument[0]}x)+c";
        }
    }
}
