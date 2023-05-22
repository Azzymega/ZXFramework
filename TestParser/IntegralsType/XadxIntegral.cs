namespace QWFramework.IntegralsType;

public class XadxIntegral : IIntegralClass
{
    public string ReturnAnswer(List<int> argument, string addon)
    {
        if (argument[0] == -1)
        {
            return "Неправильный ввод. Числовой аргумент не может обращать знаменатель в ноль.";
        }
        return addon + $"x^{argument[0] + 1}/{argument[0] + 1}+c";
    }
}