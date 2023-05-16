namespace QWFramework;
// QWFramework Rev 1.1
public class UndefineIntegralEvaluator : AEvaluator
{
    public UndefineIntegralEvaluator(string equation) : base(equation)
    {
        
    }

    public override int FindArgument(string equation)
    {
        string Argument = new string("");
        foreach (char argument in equation)
        {
            if (Char.IsDigit(argument))
            {
                Argument += argument;        
            }
        }
        if (Argument == "")
        {
            return 0;
        }
        return int.Parse(Argument);
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