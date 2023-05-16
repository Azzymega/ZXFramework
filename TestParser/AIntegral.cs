namespace QWFramework
{
    public abstract class AIntegral
    {
        protected readonly string Equation;
        protected int Argument;
        protected readonly AEvaluator Evaluator;
        protected AIntegral(string equation, AEvaluator evaluator)
        {
            this.Equation = equation;
            this.Evaluator = evaluator;
        }
        public abstract string ReturnAnswer();
    }
}