namespace QWFramework;

public class UndefineIntegralEvaluator : AEvaluator
{
    public UndefineIntegralEvaluator(string equation) : base(equation)
    {
        
    }

    public override int FindArgument(string equation)
    {
        foreach (char argument in equation)
        {
            if (Char.IsDigit(argument))
            {
                return argument;
            }
        }

        return 0;
    }

    protected override string ReturnEquationWithoutArgument(string equation)
    {
        string equationWithoutArgument = new string("");
        foreach (char symbols in equation)
        {
            if (!Char.IsDigit(symbols))
            {
                equationWithoutArgument += symbols;
            }
        }

        return equationWithoutArgument;
    }

    public override string ReturnAnswer(int argument)
    {
        return Data.Answers[Data.EquationWithoutArgument].ReturnAnswer(argument);
    }
}