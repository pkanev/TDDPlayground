namespace Tests
{
    using Katas;
    using Xunit;

    public class TwoToOneTests
    {
        [Fact]
        public void LongestShouldReturnCorrectString ()
        {
            AssertThatStringsAreEqual(TwoToOne.Longest("", ""), "");
            AssertThatStringsAreEqual(TwoToOne.Longest("a", ""), "a");
            AssertThatStringsAreEqual(TwoToOne.Longest("ba", ""), "ab");
            AssertThatStringsAreEqual(TwoToOne.Longest("ba", "c"), "abc");
            AssertThatStringsAreEqual(TwoToOne.Longest("ba", "b"), "ab");
            AssertThatStringsAreEqual(TwoToOne.Longest("aretheyhere", "yestheyarehere"), "aehrsty");
            AssertThatStringsAreEqual(TwoToOne.Longest("loopingisfunbutdangerous", "lessdangerousthancoding"), "abcdefghilnoprstu");
            AssertThatStringsAreEqual(TwoToOne.Longest("inmanylanguages", "theresapairoffunctions"), "acefghilmnoprstuy");
        }

        private void AssertThatStringsAreEqual(string actual, string expected)
        {
            Assert.Equal(expected, actual);
        }
    }
}
