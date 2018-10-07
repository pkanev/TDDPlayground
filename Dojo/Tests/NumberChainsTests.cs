using NumberChains;
using Xunit;

namespace Tests
{
    public class NumberChainsTests
    {
        [Theory]
        [InlineData(0, 1)]
        [InlineData(10, 3)]
        [InlineData(123456789, 2)]
        [InlineData(1234, 4)]
        [InlineData(444, 2)]
        public void NumberChainsSOlverShouldReturnCorrectChainLength(int input, int expected)
        {
            // Arrange
            NumberChainsSolver solver = new NumberChainsSolver();

            // Act
            int result = solver.Solver(input);

            // Assert
            Assert.Equal(expected, result);
        }

        //[Theory]
        //[InlineData(0, 0, 0)]
        //[InlineData(12, 12, 21)]
        //[InlineData(22, 22, 22)]
        //[InlineData(109, 19, 910)]
        //[InlineData(1090, 19, 9100)]
        //public void GetMaxNumberShouldReturnNumberWIthDescendingDigits(int input, params int[] expected)
        //{
        //    // Arrange
        //    NumberChainsSolver solver = new NumberChainsSolver();

        //    // Act
        //    int[] maxMinResult = solver.GetMinAndMaxNumbers(input);

        //    // Assert
        //    Assert.Equal(expected, maxMinResult);
        //}
    }
}
