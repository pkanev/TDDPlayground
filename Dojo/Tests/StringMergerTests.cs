namespace Tests
{
    using Katas;
    using Xunit;

    public class StringMergerTests
    {
        [Theory]
        [InlineData("", "", "", true)]
        [InlineData("", "", "a", false)]
        [InlineData("a", "", "a", true)]
        [InlineData("", "a", "a", true)]
        [InlineData("a", "a", "a", false)]
        [InlineData("ab", "a", "ab", true)]
        [InlineData("", "ab", "ab", true)]
        [InlineData("", "ab", "a", false)]
        [InlineData("", "a", "ab", false)]
        [InlineData("code", "wars", "codewars", true)]
        [InlineData("cdwr", "oeas", "codewars", true)]
        [InlineData("cod", "wars", "codewars", false)]
        [InlineData("wars", "code", "codewars", true)]
        [InlineData("going ", "Bananas!", "going Bananas!", true)]
        [InlineData("going A", "Bananas!", "going Bananas!", false)]
        public void StringMergerReturnsCorrectValue(string partA, string partB, string merger, bool expected)
        {
            bool result = StringMerger.isMerge(merger, partA, partB);
            Assert.Equal(expected, result);
        }
    }
}
