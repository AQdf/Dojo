using System.Collections.Generic;

namespace Sho.Dojo.Katas
{
    public class SumTheTree
    {
        // Iterative version
        public static int SumTree(Node root)
        {
            if (root == null)
            {
                return 0;
            }

            int sum = 0;
            Queue<Node> nodesQueue = new Queue<Node>();
            nodesQueue.Enqueue(root);

            while (nodesQueue.Count != 0)
            {
                Node currentNode = nodesQueue.Dequeue();

                if (currentNode != null)
                {
                    sum += currentNode.Value;

                    if (currentNode.Left != null)
                    {
                        nodesQueue.Enqueue(currentNode.Left);
                    }

                    if (currentNode.Right != null)
                    {
                        nodesQueue.Enqueue(currentNode.Right);
                    }
                }
            }

            return sum;
        }

        // Recursive version
        //public static int SumTree(Node root)
        //{
        //    return root == null ? 0 : root.Value + SumTree(root.Left) + SumTree(root.Right);
        //}
    }
}

public class Node
{
    public int Value;
    public Node Left;
    public Node Right;

    public Node(int value, Node left = null, Node right = null)
    {
        Value = value;
        Left = left;
        Right = right;
    }
}

/* Sum the Tree
Given a node object representing a binary tree write a function that returns the sum of all values, including the root.
Absence of a node will be indicated with a null value.
Examples:

10
| \
1  2
=> 13

1
| \
0  0
    \
     2
=> 3
*/
