namespace QWFramework;

public class UndefinedIntegral : AIntegral
{
    public UndefinedIntegral(String equation, AEvaluator evaluator) : base(equation, evaluator)
    {
        this.Argument = Evaluator.FindArgument(this.Equation);
    }
    public override string ReturnAnswer()
    {
        return Evaluator.ReturnAnswer(Argument);
    }
}