namespace GithubPipelinesLearning.UiTests
{
    [TestFixture]
    public class CalculatorTests
    {

        [Test]
        [TestCase(0, 0)]
        [TestCase(-1, 0)]
        [TestCase(0, -1)]
        [TestCase(1, 1)]
        [TestCase(-2147483648, 2147483647)]
        public void Calculator_Add_Doesnt_Throw_Exception(int x, int y)
        {
            Assert.DoesNotThrow(() => Calculator.Add(x, y));
        }

        [Test]
        [TestCase("asd", 0)]
        [TestCase(true, 0)]
        [TestCase(null, -1)]
        [TestCase(2134124213213212, 1)]
        [TestCase(2.5, 2.4)]
        public void Calculator_Add_Throws_Exception(object x, object y)
        {
            //Not specific line of code #-2222
            Assert.Throws<ArgumentException>(() => Calculator.Add(x, y));
        }
    }
}