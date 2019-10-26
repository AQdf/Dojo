using Sho.Dojo.Katas;
using Xunit;

namespace Sho.Dojo.Tests
{
    public class DescendingOrderTest
    {
        [Theory]
        [InlineData(0, 0)]
        [InlineData(12, 21)]
        [InlineData(11, 11)]
        [InlineData(145263, 654321)]
        [InlineData(1254859723, 9875543221)]
        public void Test(long num, long expected)
        {
            // act
            long actual = DescendingOrderKata.DescendingOrder(num);

            // assert
            Assert.Equal(expected, actual);
        }
    }
}
