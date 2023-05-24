using System.Collections.Generic;

namespace QWFramework.Core
{
    public abstract class AIntegral
    {
        protected readonly string Equation;
        protected List<int> Argument;
        protected readonly AEvaluator Evaluator;
        protected AIntegral(string equation, AEvaluator evaluator)
        {
            Equation = equation;
            Evaluator = evaluator;
        }
        public abstract string ReturnAnswer();
    }
}