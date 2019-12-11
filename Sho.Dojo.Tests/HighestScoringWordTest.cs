using Sho.Dojo.Katas;
using Xunit;

namespace Sho.Dojo.Tests
{
    public class HighestScoringWordTest
    {
        [Theory]
        [InlineData("", "")]
        [InlineData("word", "word")]
        [InlineData("man i need a taxi up to ubud", "taxi")]
        [InlineData("man i need a taxi up atix to ubud", "taxi")]
        public void Test(string input, string expected)
        {
            Assert.Equal(expected, HighestScoringWord.High(input));
        }
    }
}
