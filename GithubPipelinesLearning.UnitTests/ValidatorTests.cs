namespace GithubPipelinesLearning.UnitTests
{
    public class ValidatorTests
    {
        [Test]
        [TestCase(true, -1)]
        [TestCase(true, 1)]
        [TestCase(true, -2147483648)]
        [TestCase(true, 2147483647)]
        [TestCase(false, 0)]
        [TestCase(false, null)]
        [TestCase(false, "asd")]
        [TestCase(false, true)]
        public void IsDivider_Returns_Proper_Values(bool expectedResult, object divider)
        {
            if ((int)divider == 0)
                throw new Exception();

            Assert.That(Validator.IsDividerCorrect(divider), Is.EqualTo(expectedResult));
        }
    }
}