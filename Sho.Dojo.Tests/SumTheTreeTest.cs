using Sho.Dojo.Katas;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Sho.Dojo.Tests
{
    public class SumTheTreeTest
    {
        [Fact]
        public void OneNodeTreeThenRootValueReturned()
        {
            Node root = new Node(5);

            Assert.Equal(5, SumTheTree.SumTree(root));
        }

        [Fact]
        public void ThreeLevelTreeSumReturned()
        {
            Node level3 = new Node(3, null, null);
            Node level2 = new Node(2, level3, level3);
            Node root = new Node(1, level2, level2);

            Assert.Equal(17, SumTheTree.SumTree(root));
        }
    }
}
