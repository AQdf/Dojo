using Sho.Dojo.Katas;
using Xunit;

namespace Sho.Dojo.Tests
{
    public class FindTheNextPerfectSquareTest
    {
        [Theory]
        [InlineData(121, 144)]
        public void Test(long num, long expected)
        {
            // act
            long actual = FindTheNextPerfectSquare.FindNextSquare(num);

            // assert
            Assert.Equal(expected, actual);
        }
    }
}
