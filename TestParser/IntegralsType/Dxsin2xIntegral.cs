namespace QWFramework.IntegralsType;

public class Dxsin2xIntegral : IIntegralClass
{
    public string ReturnAnswer(List<int> argument, string addon)
    {
        return addon+"-ctg(x)+c";
    }
}