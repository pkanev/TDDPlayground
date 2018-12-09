namespace Tests
{
    using Katas;
    using Xunit;
    
    public class CamelCaseTests
    {
        [Theory]
        [InlineData("", "")]
        [InlineData("    ", "")]
        [InlineData("a", "A")]
        [InlineData("aa", "Aa")]
        [InlineData("aA", "Aa")]
        [InlineData("a a", "AA")]
        [InlineData("a          a", "AA")]
        [InlineData("test if this function WorS", "TestIfThisFunctionWors")]
        public void CamelCaseShouldReturnValidString(string input, string expected)
            => Assert.Equal(expected, input.ToCamelCase());
    }
}
