namespace QWFramework.IntegralsType;

public class XadxIntegral : IIntegralClass
{
    public string ReturnAnswer(List<int> argument, string addon)
    {
        if (addon.IndexOf('/') != -1)
        {
            string[] arguments = addon.Split('/');
            arguments[1] = arguments[1].Trim('*');
            return $"({arguments[0]}x^{argument[0] + 1})/{(argument[0] + 1) * int.Parse(arguments[1])}+c";
        }
        if (argument[0] == -1)
        {
            return "Неправильный ввод. Числовой аргумент не может обращать знаменатель в ноль.";
        }
        addon = addon.Trim('*');
        return $"({addon}x^{(argument[0] + 1)})/{argument[0] + 1}+c";
    }
}