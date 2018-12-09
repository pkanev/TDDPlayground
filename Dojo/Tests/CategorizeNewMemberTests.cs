namespace Tests
{
    using Katas;
    using Xunit;

    public class CategorizeNewMemberTests
    {
        [Fact]
        public void CategorizeNewMemberSHouldReturnValidResult()
        {
            AssertResultIsValid(new[] { new[] { 1, 2 } }, new[] { "Open" });
            AssertResultIsValid(new[] { new[] { 55, 7 } }, new[] { "Open" });
            AssertResultIsValid(new[] { new[] { 55, 8 } }, new[] { "Senior" });
            AssertResultIsValid(new[] { new[] { 45, 12 }, new[] { 55, 21 }, new[] { 19, 2 }, new[] { 104, 20 } }, new[] { "Open", "Senior", "Open", "Senior" });
            AssertResultIsValid(new[] { new[] { 3, 12 }, new[] { 55, 1 }, new[] { 91, -2 }, new[] { 54, 23 } }, new[] { "Open", "Open", "Open", "Open" });
            AssertResultIsValid(new[] { new[] { 59, 12 }, new[] { 45, 21 }, new[] { -12, -2 }, new[] { 12, 12 } }, new[] { "Senior", "Open", "Open", "Open" });
        }

        private static void AssertResultIsValid(int[][] input, string[] expected)
        {
            var result = CategorizeNewMember.OpenOrSenior(input);
            Assert.Equal(expected, result);
        }
    }
}
