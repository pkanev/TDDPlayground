using AlternatingSplit;
using Xunit;

namespace Tests
{
    public class AlternatingSplitTests
    {
        [Theory]
        [InlineData(null, 0, null)]
        [InlineData("", 1, "")]
        [InlineData("ab", 1, "ba")]
        [InlineData("This is a test!", 0, "This is a test!")]
        [InlineData("This is a test!", 1, "hsi  etTi sats!")]
        [InlineData("This is a test!", 2, "s eT ashi tist!")]
        [InlineData("This is a test!", 3, " Tah itse sits!")]
        [InlineData("This is a test!", 4, "This is a test!")]
        [InlineData("This is a test!", -1, "This is a test!")]
        [InlineData("This kata is very interesting!", 1, "hskt svr neetn!Ti aai eyitrsig")]
        public void EncryptShouldEncryptCorrectly(string input, int iterations, string expected)
            => Assert.Equal(expected, Kata.Encrypt(input, iterations));

        [Theory]
        [InlineData(null, 0, null)]
        [InlineData("", 1, "")]
        [InlineData("a", 1, "a")]
        [InlineData("ba", 1, "ab")]
        [InlineData("This is a test!", 0, "This is a test!")]
        [InlineData("hsi  etTi sats!", 1, "This is a test!")]
        [InlineData("s eT ashi tist!", 2, "This is a test!")]
        [InlineData(" Tah itse sits!", 3, "This is a test!")]
        [InlineData("This is a test!", 4, "This is a test!")]
        [InlineData("This is a test!", -1, "This is a test!")]
        [InlineData("hskt svr neetn!Ti aai eyitrsig", 1, "This kata is very interesting!")]
        public void DecryptShouldReturnOriginalValue(string encrypted, int iterations, string expected)
            => Assert.Equal(expected, Kata.Decrypt(encrypted, iterations));

    }
}
