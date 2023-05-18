namespace QWFramework
{
    using System;
    // QWFramework Rev 1.4
    public class UndefineIntegralEvaluator : AEvaluator
    {
        public UndefineIntegralEvaluator(string equation) : base(equation)
        {

        }


        public override int FindArgument(string equation)
        {
            bool minus = false;
            string Argument = "0";
            for (int i = 0; i < equation.Length; i++)
            {
                if (Char.IsDigit(equation[i]) && equation[i - 1] != '^')
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

        protected override string ReturnEquationWithoutArgument(string equation)
        {
            string equationWithoutArgument = "";
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
}