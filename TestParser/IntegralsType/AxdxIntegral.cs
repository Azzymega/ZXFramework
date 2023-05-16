namespace QWFramework.IntegralsType
{
    public class AxdxIntegral : IIntegralClass
    {
        public string ReturnAnswer(int argument)
        {
            return $"{argument}^x/ln({argument})+c";
        }
    }
}