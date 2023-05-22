namespace QWFramework.IntegralsType;

public class AxdxIntegral : IIntegralClass
{
    public string ReturnAnswer(List<int> argument, string addon)
    {
        return addon+$"{argument[0]}^x/ln({argument[0]})+c";
    }
}