using Sho.Dojo.Katas;
using Xunit;

namespace Sho.Dojo.Tests
{
    public class PlayWithTwoStringsTest
    {
        private readonly PlayWithTwoStrings playWithTwoStrings = new PlayWithTwoStrings();

        [Theory]
        [InlineData("abc", "def", "abcdef")]
        [InlineData("abc", "bbb", "aBcBBB")]
        [InlineData("abab", "bababa", "ABABbababa")]
        [InlineData("abcdeFg", "defgG", "abcDEfgDEFGg")]
        [InlineData("abcdeFgtrzw", "defgGgfhjkwqe", "abcDeFGtrzWDEFGgGFhjkWqE")]
        public void Test(string a, string b, string expected)
        {
            Assert.Equal(expected, playWithTwoStrings.workOnStrings(a, b));
        }
    }
}