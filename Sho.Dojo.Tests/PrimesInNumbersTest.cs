using Sho.Dojo.Katas;
using Xunit;

namespace Sho.Dojo.Tests
{
    public class PrimesInNumbersTest
    {
        [Theory]
        [InlineData(1, "")]
        [InlineData(2, "(2)")]
        [InlineData(3, "(3)")]
        [InlineData(4, "(2**2)")]
        [InlineData(256, "(2**8)")]
        [InlineData(257, "(257)")]
        [InlineData(139, "(139)")]
        [InlineData(86240, "(2**5)(5)(7**2)(11)")]
        [InlineData(7775460, "(2**2)(3**3)(5)(7)(11**2)(17)")]
        public void Test(int number, string expected)
        {
            // act
            string actual = PrimesInNumbers.Factors(number);

            // assert
            Assert.Equal(expected, actual);
        }
    }
}
