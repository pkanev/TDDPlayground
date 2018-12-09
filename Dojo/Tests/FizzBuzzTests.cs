namespace Tests
{
    using Katas;
    using System.Collections.Generic;
    using Xunit;

    public class FizzBuzzTests
    {
        [Theory]
        [InlineData(0, "")]
        [InlineData(1, "1")]
        [InlineData(2, "1,2")]
        [InlineData(3, "1,2,Fizz")]
        [InlineData(4, "1,2,Fizz,4")]
        [InlineData(5, "1,2,Fizz,4,Buzz")]
        [InlineData(14, "1,2,Fizz,4,Buzz,Fizz,7,8,Fizz,Buzz,11,Fizz,13,14")]
        [InlineData(15, "1,2,Fizz,4,Buzz,Fizz,7,8,Fizz,Buzz,11,Fizz,13,14,FizzBuzz")]
        public void WhenFIzzBuzzShouldPrintCorrectValues(int limit, string expected)
        {
            FizzBuzz processor = new FizzBuzz();
            string result = processor.PrintResult(limit);
            Assert.Equal(expected, result);
        }
    }
}
