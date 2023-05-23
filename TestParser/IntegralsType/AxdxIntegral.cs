using QWFramework.Core;

namespace QWFramework.IntegralsType;

public class AxdxIntegral : IIntegralClass
{
    public string ReturnAnswer(List<int> argument, string addon)
    {
        if (argument[0] == 1)
        {
            return "Переменная A не может равняться 1.";
        }
        if (addon.IndexOf('/') != -1)
        {
            string[] arguments = addon.Split('/');
            arguments[1] = arguments[1].Trim('*');
            return $"({arguments[0]}*({argument[0]}^x)/{arguments[1]}ln({argument[0]}))+c";
        }
        addon = addon.Trim('*');
        return $"{addon}*{argument[0]}^x/ln({argument[0]})+c";
    }
}