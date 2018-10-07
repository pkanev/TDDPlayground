using JadenCase;
using Xunit;

namespace Tests
{
    public class JadenCaseTests
    {
        [Fact]
        public void JadenCaseShouldReturnCorrectValues()
        {
            AssertResultEqualsExpected("".ToJadenCase(), string.Empty);
            AssertResultEqualsExpected("A".ToJadenCase(), "A");
            AssertResultEqualsExpected("a".ToJadenCase(), "A");
            AssertResultEqualsExpected("aa".ToJadenCase(), "Aa");
            AssertResultEqualsExpected("AA".ToJadenCase(), "Aa");
            AssertResultEqualsExpected("a a".ToJadenCase(), "A A");
            AssertResultEqualsExpected("a aa".ToJadenCase(), "A Aa");
            AssertResultEqualsExpected("a a, a".ToJadenCase(), "A A, A");
            AssertResultEqualsExpected("a a: a".ToJadenCase(), "A A: A");
            AssertResultEqualsExpected("a.a, a".ToJadenCase(), "A.A, A");
        }

        private void AssertResultEqualsExpected(string actual, string expected)
            => Assert.Equal(expected, actual);
    }
}
