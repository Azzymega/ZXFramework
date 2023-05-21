namespace QWFramework.IntegralsType;

public class XadxIntegral : IIntegralClass
{
    public string ReturnAnswer(int argument, string addon)
    {
        if (argument == -1)
        {
            return "Неправильный ввод. Числовой аргумент не может обращать знаменатель в ноль.";
        }
        return addon+$"x^{argument + 1}/{argument + 1}+c";
    }
}