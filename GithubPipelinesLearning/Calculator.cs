namespace GithubPipelinesLearning
{
    public class Calculator
    {
        public static int Add(object x, object y)
        {
            if (!Validator.IsNumberCorrect(x) || !Validator.IsNumberCorrect(y))
                throw new ArgumentException();

            return (int)x + (int)y;
        }

        public static double Divide(int x, int y)
        {
            if (!Validator.IsNumberCorrect(x) || !Validator.IsNumberCorrect(y) || !Validator.IsDividerCorrect(y))
                throw new ArgumentException();

            return x / y;
        }
    }
}
