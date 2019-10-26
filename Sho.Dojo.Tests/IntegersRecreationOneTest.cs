using Sho.Dojo.Katas;
using Xunit;

namespace Sho.Dojo.Tests
{
    public class IntegersRecreationOneTest
    {
        [Theory]
        [InlineData(1, 250, "[[1, 1], [42, 2500], [246, 84100]]")]
        [InlineData(250, 500, "[[287, 84100]]")]
        public void Test(long from, long to, string expected)
        {
            // act
            string actual = IntegersRecreationOne.listSquared(from, to);

            // assert
            Assert.Equal(expected, actual);
        }
    }
}
