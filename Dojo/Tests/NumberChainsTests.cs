﻿namespace Tests
{
    using Katas;
    using Xunit;

    public class NumberChainsTests
    {
        [Theory]
        [InlineData(0, 1)]
        [InlineData(1, 2)]
        [InlineData(10, 3)]
        [InlineData(11, 2)]
        [InlineData(123456789, 2)]
        [InlineData(1234, 4)]
        [InlineData(444, 2)]
        public void NumberChainsSolverShouldReturnCorrectChainLength(int input, int expected)
        {
            // Arrange
            NumberChains solver = new NumberChains();

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
