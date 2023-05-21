namespace QWFramework.IntegralsType;

public class AxdxIntegral : IIntegralClass
{
    public string ReturnAnswer(int argument, string addon)
    {
        return $"{argument}^x/ln({argument})+c";
    }
}