using Sho.Dojo.Katas;
using Xunit;

namespace Sho.Dojo.Tests
{
    public class WhatsPerfectPowerAnywayTest
    {
        [Theory]
        //[InlineData(4, 2, 2)]
        //[InlineData(9, 3, 2)]
        //[InlineData(125, 9, 2)]
        [InlineData(6859, 19, 3)]
        public void ShouldBePerfect(int n, int baseNumber, int power)
        {
            (int, int)? actual = WhatsPerfectPowerAnyway.IsPerfectPower(n);

            Assert.True(actual.HasValue);
            Assert.Equal((baseNumber, power), actual);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        public void ShouldNotBePerfect(int n)
        {
            Assert.Null(WhatsPerfectPowerAnyway.IsPerfectPower(n));
        }

        [Fact]
        public void ShouldBeInOneOfMultipleExpectedResults()
        {
            int n = 16;
            (int baseNum, int power)[] expectedResults = new[] { (2, 4), (4, 2) };

            (int, int)? actual = WhatsPerfectPowerAnyway.IsPerfectPower(n);

            Assert.True(actual.HasValue);
            Assert.Contains(expectedResults, pair => pair.baseNum == actual.Value.Item1 && pair.power == actual.Value.Item2);
        }

        [Fact]
        public void TestUpTo500()
        {
            var pp = new int[] { 4, 8, 9, 16, 25, 27, 32, 36, 49, 64, 81, 100, 121, 125, 128, 144, 169, 196, 216, 225, 243, 256, 289, 324, 343, 361, 400, 441, 484 };
            foreach (var i in pp)
                Assert.True(WhatsPerfectPowerAnyway.IsPerfectPower(i) != null, $"{i} is a perfect power");
        }
    }
}
