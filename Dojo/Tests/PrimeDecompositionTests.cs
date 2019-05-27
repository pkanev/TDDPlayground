namespace Tests
{
    using Katas;
    using Xunit;

    public class PrimeDecompositionTests
    {
        [Theory]
        [InlineData(2, "(2)")]
        [InlineData(4, "(2**2)")]
        [InlineData(3, "(3)")]
        [InlineData(8, "(2**3)")]
        [InlineData(9, "(3**2)")]
        [InlineData(30, "(2)(3)(5)")]
        [InlineData(86240, "(2**5)(5)(7**2)(11)")]
        [InlineData(7775460, "(2**2)(3**3)(5)(7)(11**2)(17)")]
        public void FactorReturnsCorrectValues(int number, string expected)
        {
            string result = PrimeDecomposition.Factors(number);
            Assert.Equal(expected, result);
        }
    }
}
