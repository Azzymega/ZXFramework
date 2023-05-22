using QWFramework.IntegralsType;

namespace QWFramework;

public abstract class AEvaluator
{
    protected SBufferData Data;
    public abstract List<int> FindArgument(string equation);
    protected abstract string ReturnEquationWithoutArgument(string equation);
    public abstract string ReturnAnswer(List<int> argument);

    protected AEvaluator(string equation)
    {
        Data.Answers = new Dictionary<string, IIntegralClass>() 
        {{"dx",new DxIntegral()},{"x^dx",new XadxIntegral()},
        {"dxx",new DxxIntegral()},{"^xdx",new AxdxIntegral()},
        {"e^xdx",new ExdxIntegral()},{"dxsin^(x)",new Dxsin2xIntegral()},
        {"cos(x)dx",new CosaxdxIntegral()}, {"sin(x)dx", new SinaxdxIntegral()},
        {"dx(^+x^)",new Dxa2x2Integral() },{ "dx(x^^)",new Dxx2a2Integral()} };
        Data.EquationWithoutArgument = ReturnEquationWithoutArgument(equation);
    }
}