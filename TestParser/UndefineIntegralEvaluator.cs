namespace QWFramework;
// QWFramework Rev 1.2
public class UndefineIntegralEvaluator : AEvaluator
{
    public UndefineIntegralEvaluator(string equation) : base(equation)
    {
        
    }

    public override int FindArgument(string equation)
    {
        bool minus = false;
        string Argument = new string("0");
        foreach (char argument in equation)
        {
            if (Char.IsDigit(argument))
            {
                Argument += argument;        
            }
            if (argument == '-')
            {
                minus = true;
            }
        }
        if (minus == true)
        {
            return -1*int.Parse(Argument);
        }
        return int.Parse(Argument);
    }

    protected override string ReturnEquationWithoutArgument(string equation)
    {
        string equationWithoutArgument = new string("");
        foreach (char symbols in equation)
        {
            if (!Char.IsDigit(symbols) && symbols != '-')
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