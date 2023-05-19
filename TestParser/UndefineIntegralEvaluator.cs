namespace QWFramework;
// QWFramework Rev 1.7
public class UndefineIntegralEvaluator : AEvaluator
{
    public UndefineIntegralEvaluator(string equation) : base(equation) { }

    public override int FindArgument(string equation)
    {
        int count = 0;
        foreach (char c in equation)
        {
            if (Char.IsDigit(c))
            {
                count++;
            }
        }
        if (count > 1)
        {
        bool minus = false;
        string Argument = new string("0");
        for (int i = 0; i < equation.Length; i++)
        {
            if (Char.IsDigit(equation[i]) && equation[i-1] != '^')
            {
                Argument += equation[i];        
            }
            if (equation[i] == '-')
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
        else
        {
            bool minus = false;
            string Argument = new string("0");
            for (int i = 0; i < equation.Length; i++)
            {
                if (Char.IsDigit(equation[i]))
                {
                    Argument += equation[i];
                }
                if (equation[i] == '-')
                {
                    minus = true;
                }
            }
            if (minus == true)
            {
                return -1 * int.Parse(Argument);
            }
            return int.Parse(Argument);
        }
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