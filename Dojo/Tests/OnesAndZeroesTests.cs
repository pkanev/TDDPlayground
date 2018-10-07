using OnesAndZeroes;
using Xunit;

namespace Tests
{
    public class OnesAndZeroesTests
    {
        [Fact]
        public void ConvertionFromBinaryShouldReturnCorrectNumnber()
        {
            BinaryArrayToNumberShouldReturnCorrectNumber(new int[] { }, 0);
            BinaryArrayToNumberShouldReturnCorrectNumber(new int[] { 0 }, 0);
            BinaryArrayToNumberShouldReturnCorrectNumber(new int[] { 1 }, 1);
            BinaryArrayToNumberShouldReturnCorrectNumber(new int[] { 0, 0 }, 0);
            BinaryArrayToNumberShouldReturnCorrectNumber(new int[] { 1, 0 }, 2);
            BinaryArrayToNumberShouldReturnCorrectNumber(new int[] { 1, 1 }, 3);
            BinaryArrayToNumberShouldReturnCorrectNumber(new int[] { 1, 0, 4 }, 8);
            BinaryArrayToNumberShouldReturnCorrectNumber(new int[] { 0, 0, 0, 0 }, 0);
            BinaryArrayToNumberShouldReturnCorrectNumber(new int[] { 1, 1, 1, 1 }, 15);
            BinaryArrayToNumberShouldReturnCorrectNumber(new int[] { 0, 1, 1, 0 }, 6);
            BinaryArrayToNumberShouldReturnCorrectNumber(new int[] { 0, 1, 0, 1 }, 5);
        }

        private void BinaryArrayToNumberShouldReturnCorrectNumber(int[] binaryArray, int expected)
        {
            int result = Kata.BinaryArrayToNumber(binaryArray);
            Assert.Equal(expected, result);
        }
    }
}
