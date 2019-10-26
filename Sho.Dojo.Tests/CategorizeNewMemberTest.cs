using Xunit;
using Sho.Dojo.Katas;
using System.Collections.Generic;

namespace Sho.Dojo.Tests
{
    public class CategorizeNewMemberTest
    {
        [Fact]
        public void DafaultTest()
        {
            // arrange
            var expected = new List<string>();
            int[][] data = new int[][] { };

            // act
            IEnumerable<string> actual = CategorizeNewMember.OpenOrSenior(data);

            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FewMembersCategorizingTest()
        {
            // arrange
            string[] expected = new string[] { "Open", "Open", "Senior", "Open", "Open", "Senior" };
            int[][] data = new int[][] { new int[] { 18, 20 }, new int[] { 45, 2 }, new int[] { 61, 12 }, new int[] { 37, 6 }, new int[] { 21, 21 }, new int[] { 78, 9 } };

            // act
            IEnumerable<string> actual = CategorizeNewMember.OpenOrSenior(data);

            // assert
            Assert.Equal(expected, actual);
        }
    }
}
