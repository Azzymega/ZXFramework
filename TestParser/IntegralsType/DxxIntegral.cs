using QWFramework.Core;

namespace QWFramework.IntegralsType;

public class DxxIntegral : IIntegralClass
{
    public string ReturnAnswer(List<int> argument, string addon)
    {
        return addon+"ln|x|+c";
    }
}