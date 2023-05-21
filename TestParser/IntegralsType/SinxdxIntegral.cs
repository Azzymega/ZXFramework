namespace QWFramework.IntegralsType;

public class SinxdxIntegral : IIntegralClass
{
    public string ReturnAnswer(int argument, string addon)
    {
        return addon+"-cos(x)+c";
    }
}