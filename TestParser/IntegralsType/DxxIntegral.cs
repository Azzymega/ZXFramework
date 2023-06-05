using QWFramework.Core;

namespace QWFramework.IntegralsType;

public class DxxIntegral : IIntegralClass
{
    public string ReturnAnswer(List<int> argument, string addon)
    {
        if (addon.IndexOf('/') != -1)
        {
            string[] arguments = addon.Split('/');
            arguments[1] = arguments[1].Trim('*');
            return $"({arguments[0]}ln|x|/{arguments[1]})+c";
        }
        return addon+"ln|x|+c";
    }
}