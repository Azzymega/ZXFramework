using QWFramework.Core;

namespace QWFramework.IntegralsType;

public class ExdxIntegral : IIntegralClass
{
    public string ReturnAnswer(List<int> argument, string addon)
    {
        return addon+"e^x+c";
    }
}