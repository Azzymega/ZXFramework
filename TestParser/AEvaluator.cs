using QWFramework.IntegralsType;

namespace QWFramework;

public abstract class AEvaluator
{
    protected SBufferData Data;
    public abstract int FindArgument(string equation);
    protected abstract string ReturnEquationWithoutArgument(string equation);
    public abstract string ReturnAnswer(int argument);

    protected AEvaluator(string equation)
    {
        Data.Answers = new Dictionary<string, IIntegralClass>() {{"dx",new DxIntegral()},{"x^dx",new XadxIntegral()},
            {"dx/x",new DxxIntegral()},{"^xdx",new AxdxIntegral()},{"e^xdx",new ExdxIntegral()},
            {"sin(x)dx",new SinxdxIntegral()},{"cos(x)dx", new CosxdxIntegral()},{"dx/sin^(x)",new Dxsin2xIntegral()} };
        Data.EquationWithoutArgument = ReturnEquationWithoutArgument(equation);
    }
}