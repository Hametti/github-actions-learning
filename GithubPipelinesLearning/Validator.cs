namespace GithubPipelinesLearning
{
    public class Validator
    {
        public static bool IsNumberCorrect(object x)
        {
            if (!(x is int))
                return false;

            return true;
        }

        public static bool IsDividerCorrect(object x)
        {
            if (!(x is int))
                return false;

            if ((int)x == 0)
                return false;

            return true;
        }
    }
}
