namespace QWFramework.Core;

public class UndefinedIntegral : AIntegral
{
    public UndefinedIntegral(string equation, AEvaluator evaluator) : base(equation, evaluator)
    {
        Argument = Evaluator.FindArgument(Equation);
    }
    public override string ReturnAnswer()
    {
        return Evaluator.ReturnAnswer(Argument);
    }
}