using RGBToHex;
using Xunit;

namespace Tests
{
    public class RGBToHexTests
    {
        [Theory]
        [InlineData(0, 0, 0, "000000")]
        [InlineData(255, 255, 300, "FFFFFF")]
        [InlineData(255, 255, -20, "FFFF00")]
        [InlineData(212, 53, 12, "D4350C")]        
        public void RGBShouldReturnCorrectHexadecimalValue(int red, int green, int blue, string expected)
            => Assert.Equal(expected, Kata.Rgb(red, green, blue));
    }
}
