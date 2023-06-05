using QWFramework.Core;

namespace QWFramework.IntegralsType;

public class ExdxIntegral : IIntegralClass
{
    public string ReturnAnswer(List<int> argument, string addon)
    {
        if (addon.IndexOf('/') != -1)
        {
            string[] arguments = addon.Split('/');
            arguments[1] = arguments[1].Trim('*');
            return $"({arguments[0]}(e^x)/{arguments[1]})+c";
        }
        return addon+"e^x+c";
    }
}