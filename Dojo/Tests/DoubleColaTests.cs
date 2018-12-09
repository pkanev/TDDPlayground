namespace Tests
{
    using Katas;
    using Xunit;

    public class DoubleColaTests
    {
        [Theory]
        [InlineData("Sheldon", 1, "Sheldon")]
        [InlineData("Leonard", 2, "Sheldon", "Leonard")]
        [InlineData("Sheldon", 3, "Sheldon", "Leonard")]
        [InlineData("Sheldon", 4, "Sheldon", "Leonard")]
        [InlineData("Sheldon", 6, "Sheldon", "Leonard", "Penny", "Rajesh", "Howard")]
        [InlineData("Penny", 52, "Sheldon", "Leonard", "Penny", "Rajesh", "Howard")]
        [InlineData("Leonard", 7230702951, "Sheldon", "Leonard", "Penny", "Rajesh", "Howard")]
        public void NextInLineShouldReturnCorrectPerson(string expected, long turn, params string[] queue)
        {
            AssertThatAreEqual(DoubleCola.WhoIsNext(queue, turn), expected);
        }

        private void AssertThatAreEqual(string actual, string expected)
        {
            Assert.Equal(expected, actual);
        }
    }
}
