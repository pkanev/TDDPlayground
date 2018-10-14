using TwoToOne;
using Xunit;

namespace Tests
{
    public class TwoToOneTests
    {
        [Fact]
        public void LongestShouldReturnCorrectString ()
        {
            AssertThatStringsAreEqual(Kata.Longest("", ""), "");
            AssertThatStringsAreEqual(Kata.Longest("a", ""), "a");
            AssertThatStringsAreEqual(Kata.Longest("ba", ""), "ab");
            AssertThatStringsAreEqual(Kata.Longest("ba", "c"), "abc");
            AssertThatStringsAreEqual(Kata.Longest("ba", "b"), "ab");
            AssertThatStringsAreEqual(Kata.Longest("aretheyhere", "yestheyarehere"), "aehrsty");
            AssertThatStringsAreEqual(Kata.Longest("loopingisfunbutdangerous", "lessdangerousthancoding"), "abcdefghilnoprstu");
            AssertThatStringsAreEqual(Kata.Longest("inmanylanguages", "theresapairoffunctions"), "acefghilmnoprstuy");
        }

        private void AssertThatStringsAreEqual(string actual, string expected)
        {
            Assert.Equal(expected, actual);
        }
    }
}
