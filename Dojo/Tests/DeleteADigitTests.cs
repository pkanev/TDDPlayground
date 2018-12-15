namespace Tests
{
    using System;
    using Katas;
    using Xunit;

    public class DeleteADigitTests
    {
        private readonly DeleteADigit digitDeleter;

        private const int MIN = 10;
        private const int MAX = 1000000;

        public DeleteADigitTests()
        {
            this.digitDeleter = new DeleteADigit();
        }

        [Fact]
        public void DeleteADigitReturnsCorrectValue()
        {
            AssertAreEqual(digitDeleter.DeleteDigit(10), 1);
            AssertAreEqual(digitDeleter.DeleteDigit(152), 52);
            AssertAreEqual(digitDeleter.DeleteDigit(1001), 101);
        }

        [Fact]
        public void PassingAnIntegerOutOfRangeShouldThrow()
        {
            AssertThatThrows(MIN - 1);
            AssertThatThrows(MAX + 1);
        }

        private void AssertThatThrows(int number)
            => Assert.Throws<ArgumentOutOfRangeException>(delegate { digitDeleter.DeleteDigit(number); });

        private void AssertAreEqual(int actual, int expected) => Assert.Equal(expected, actual);
    }
}
