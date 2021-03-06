﻿namespace Tests
{
    using Katas;
    using System.Collections.Generic;
    using Xunit;

    public class UniqueInOrderTests
    {
        [Fact]
        public void UniqueInOrderReturnsCorrectResults()
        {
            ValidateResults("", "");
            ValidateResults("AAAABBBCCDAABBB", "ABCDAB");
            ValidateResults(new[] { 1, 2, 2, 3, 3 }, new[] { 1, 2, 3 });
    }

        private void ValidateResults<T>(IEnumerable<T> input, IEnumerable<T> expected)
        {
            var actual = UniqueInOrder.ToUniqueInOrder(input);
            Assert.Equal(expected, actual);
        }
    }
}
