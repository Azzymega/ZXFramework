namespace QWFramework.IntegralsType;

public class DxxIntegral : IIntegralClass
{
    public string ReturnAnswer(int argument, string addon)
    {
        return addon+"ln|x|+c";
    }
}