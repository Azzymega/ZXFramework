namespace QWFramework;
// QWFramework RC
public class UndefineIntegralEvaluator : AEvaluator
{
    private string _addon;
    public UndefineIntegralEvaluator(string equation) : base(equation) {_addon = "";}

    public override int FindArgument(string equation)
    {
        List<String> blocks = new List<string>();
        string block = "";
        foreach (var ch in equation)
        {
            if (ch == '*')
            {
                blocks.Add(block);
                block = "";
            }
            else
            {
                block += ch;
            }
        }
        blocks.Add(block);
        for (int i = 0; i < blocks.Count; i++)
        {
            foreach (var str in blocks[i])
            {
                if (str == 'd')
                {
                    _addon += blocks[i - 1];
                    _addon += '*';
                    break;
                }
            }
        }
        int count = 0;
        for (int i = 0; i < equation.Length; i++)
        {
            if (Char.IsDigit(equation[i]) && equation[i+1] != '*' && Char.IsDigit(equation[i+1]))
            {
                count++;
            }
        }
        if (count > 1)
        {
            bool minus = false;
            string argument = "";
            for (int i = 0; i < equation.Length; i++)
            {
                if (Char.IsDigit(equation[i]) && equation[i-1] != '^')
                {
                    argument += equation[i];        
                }
                if (equation[i] == '-')
                {
                    minus = true;
                }
            }
            if (minus)
            {
                return -1*int.Parse(argument);
            }
            return int.Parse(argument);
        }
        else
        {
            bool minus = false;
            string argument = "";
            for (int i = 0; i < equation.Length; i++)
            {
                if (Char.IsDigit(equation[i]) && i != 0)
                {
                    argument += equation[i];
                }
                if (equation[i] == '-')
                {
                    minus = true;
                }
            }
            if (minus)
            {
                return -1 * int.Parse(argument);
            }
            return int.Parse(argument);
        }
    }

    protected override string ReturnEquationWithoutArgument(string equation)
    {
        string equationWithoutArgument = new string("");
        foreach (char symbols in equation)
        {
            if (!Char.IsDigit(symbols) && symbols != '-' && symbols != '*')
            {
                equationWithoutArgument += symbols;
            }
        }
        return equationWithoutArgument;
    }

    public override string ReturnAnswer(int argument)
    {
        return Data.Answers[Data.EquationWithoutArgument].ReturnAnswer(argument, _addon);
    }
}