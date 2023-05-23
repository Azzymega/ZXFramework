namespace QWFramework.Core;
// QWFramework RC Update 5
public class UndefineIntegralEvaluator : AEvaluator
{
    private string _addon;
    public UndefineIntegralEvaluator(string equation) : base(equation) { _addon = ""; }

    public override List<int> FindArgument(string equation)
    {
        List<string> blocks = new List<string>();
        string block = "";
        foreach (char letter in equation)
        {
            if (letter == '*')
            {
                blocks.Add(block);
                block = "";
            }
            block += letter;
        }
        string currentEquation = "";
        blocks.Add(block);
        for (int i = 0; i < blocks.Count; i++)
        {
            foreach (char letter in blocks[i])
            {
                if (letter == 'd')
                {
                    currentEquation = blocks[i];
                    blocks.Remove(blocks[i]);
                    break;
                }
            }
        }
        foreach (string addonBlock in blocks)
        {
            _addon += addonBlock;
            _addon += '*';
        }
        List<int> ints = new List<int>();
        string num = "";
        foreach (char letter in currentEquation)
        {
            if (char.IsDigit(letter))
            {
                num += letter;
                //ints.Add(int.Parse(letter.ToString()));
            }
            else if (!char.IsDigit(letter) && num != "")
            {
                ints.Add(int.Parse(num));
                num = "";
            }
        }
        return ints;
    }

    protected override string ReturnEquationWithoutArgument(string equation)
    {
        string equationWithoutArgument = new string("");
        foreach (char symbols in equation)
        {
            if (!char.IsDigit(symbols) && symbols != '-' && symbols != '*' && symbols != '/')
            {
                equationWithoutArgument += symbols;
            }
        }
        return equationWithoutArgument;
    }

    public override string ReturnAnswer(List<int> arguments)
    {
        return Data.Answers[Data.EquationWithoutArgument].ReturnAnswer(arguments, _addon);
    }
}