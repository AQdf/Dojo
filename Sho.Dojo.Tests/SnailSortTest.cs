using Sho.Dojo.Katas;
using Xunit;

namespace Sho.Dojo.Tests
{
    public class SnailSortTest
    {
        [Fact]
        public void EmptyMatrix()
        {
            Assert.Equal(new int[0], SnailSort.Snail(new int[][] { new int[0] }));
        }

        [Fact]
        public void SizeOneMatrix()
        {
            Assert.Equal(new int[] { 1 }, SnailSort.Snail(new int[][] { new int[] { 1 } }));
        }

        [Fact]
        public void SizeTwoMatrix()
        {
            Assert.Equal(new int[] { 1, 2, 4, 3 }, SnailSort.Snail(new int[][] { new int[] { 1, 2 }, new int[] { 3, 4 } }));
        }

        [Fact]
        public void SizeThreeMatrix()
        {
            Assert.Equal(new int[] { 1, 2, 3, 6, 9, 8, 7, 4, 5 }, SnailSort.Snail(new int[][] { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 7, 8, 9 } }));
        }

        [Fact]
        public void SizeFourMatrix()
        {
            Assert.Equal(new int[] { 1, 2, 3, 4, 8, 12, 16, 15, 14, 13, 9, 5, 6, 7, 11, 10 }, SnailSort.Snail(new int[][] { new int[] { 1, 2, 3, 4 }, new int[] { 5, 6, 7, 8 }, new int[] { 9, 10, 11, 12 }, new int[] { 13, 14, 15, 16 } }));
        }
    }
}
