using Sho.Dojo.Katas;
using Xunit;

namespace Sho.Dojo.Tests
{
    public class NewCashierDoesNotKnowAboutSpaceOrShiftTest
    {
        [Theory]
        [InlineData("", "")]
        [InlineData("milkshakepizza", "Pizza Milkshake")]
        [InlineData("milkshakepizzapizza", "Pizza Pizza Milkshake")]
        [InlineData("milkshakepizzachickenfriescokeburgerpizzasandwichmilkshakepizza", "Burger Fries Chicken Pizza Pizza Pizza Sandwich Milkshake Milkshake Coke")]
        public void Test(string input, string expected)
        {
            Assert.Equal(expected, NewCashierDoesNotKnowAboutSpaceOrShift.GetOrder(input));
        }
    }
}