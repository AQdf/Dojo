using Sho.Dojo.Katas;
using Xunit;

namespace Sho.Dojo.Tests
{
    public class SortTheOddTest
    {
        [Fact]
        public void GivenEmptyArrayThenEmptyArrayReturned()
        {
            Assert.Equal(new int[] { }, SortTheOdd.SortArray(new int[] { }));
        }

        [Fact]
        public void GivenOnlyEvensArrayThenSameArrayReturned()
        {
            Assert.Equal(new int[] { 2, 8, 6, 10 }, SortTheOdd.SortArray(new int[] { 2, 8, 6, 10 }));
        }

        [Fact]
        public void GivenOnlyOddsArrayThenSortedArrayReturned()
        {
            Assert.Equal(new int[] { 3, 7, 9, 15 }, SortTheOdd.SortArray(new int[] { 7, 3, 15, 9 }));
        }

        [Fact]
        public void GivenArrayWithOddsAndEvensThenOddsSortedArrayReturned()
        {
            Assert.Equal(new int[] { 3, 20, 7, 9, 8, 15 }, SortTheOdd.SortArray(new int[] { 7, 20, 3, 15, 8, 9 })); 
        }
    }
}
