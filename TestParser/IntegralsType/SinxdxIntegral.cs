using QWFramework.Core;

namespace QWFramework.IntegralsType;

public class SinxdxIntegral : IIntegralClass
{
    public string ReturnAnswer(List<int> argument, string addon)
    {
        return addon+"-cos(x)+c";
    }
}