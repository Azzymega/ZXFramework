using QWFramework.IntegralsType;
using System;
using System.Collections.Generic;
namespace QWFramework
{
    public abstract class AEvaluator
    {
        protected SBufferData Data;
        public abstract int FindArgument(string equation);
        protected abstract string ReturnEquationWithoutArgument(string equation);
        public abstract string ReturnAnswer(int argument);

        protected AEvaluator(string equation)
        {
            Data.Answers = new Dictionary<string, IIntegralClass>()
            {{"dx",new DxIntegral()},{"x^dx",new XadxIntegral()},
            {"dx/x",new DxxIntegral()},{"^xdx",new AxdxIntegral()},
            {"e^xdx",new ExdxIntegral()},{"dx/sin^(x)",new Dxsin2xIntegral()},
            {"cos(x)dx",new CosaxdxIntegral()}, {"sin(x)dx", new SinaxdxIntegral()},
            {"dx/(^+x^)",new Dxa2x2Integral() },{ "dx/(x^^)",new Dxx2a2Integral()} };
            Data.EquationWithoutArgument = ReturnEquationWithoutArgument(equation);
        }
    }
}