using Sho.Dojo.Katas;
using Xunit;

namespace Sho.Dojo.Tests
{
    public class SortOneThreeTwoTest
    {
        [Fact]
        public void EmptyArrayInput_EmptyArrayReturned()
        {
            Assert.Equal(new int[0], SortOneThreeTwo.Sort(new int[0]));
        }

        [Fact]
        public void SimpleArrayInput_SortedArrayReturned()
        {
            Assert.Equal(new[] { 4, 1, 3, 2 }, SortOneThreeTwo.Sort(new[] { 1, 2, 3, 4 }));
        }

        [Fact]
        public void ArrayWithDuplicatesInput_SortedArrayReturned()
        {
            Assert.Equal(new[] { 8, 8, 9, 9, 10, 10 }, SortOneThreeTwo.Sort(new[] { 8, 9, 8, 10, 9, 10 }));
        }

        [Fact]
        public void ArrayWithMultidigitNumbersInput_SortedArrayReturned()
        {
            Assert.Equal(new[] { 9, 999, 99 }, SortOneThreeTwo.Sort(new[] { 9, 99, 999 }));
        }

        [Fact]
        public void SpecificInput_SortedArrayReturned()
        {
            Assert.Equal(new[] { 111, 156, 101, 7 }, SortOneThreeTwo.Sort(new[] { 7, 111, 101, 156 }));
        }
    }
}
