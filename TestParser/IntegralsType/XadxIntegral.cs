namespace QWFramework.IntegralsType
{
    public class XadxIntegral : IIntegralClass
    {
        public string ReturnAnswer(int argument)
        {
            if (argument == -1)
            {
                return "Неправильный ввод. Числовой аргумент не может быть отрицательным.";
            }
            return $"x^{argument + 1}/{argument + 1}+c";
        }
    }
}