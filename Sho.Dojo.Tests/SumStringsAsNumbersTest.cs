using Sho.Dojo.Katas;
using Xunit;

namespace Sho.Dojo.Tests
{
    public class SumStringsAsNumbersTest
    {
        [Theory]
        [InlineData("123", "456", "579")]
        [InlineData("", "456", "456")]
        [InlineData("999999999999999999999999999999999999999999999999999999999999999999999999999999999998", "1", "999999999999999999999999999999999999999999999999999999999999999999999999999999999999")]
        public void Test(string a, string b, string expected)
        {
            Assert.Equal(expected, SumStringsAsNumbers.sumStrings(a, b));
        }
    }
}
