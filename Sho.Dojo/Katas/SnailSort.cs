
namespace Sho.Dojo.Katas
{
    public class SnailSort
    {
        public static int[] Snail(int[][] array)
        {
            if (array.Length == 1 && array[0].Length == 0)
            {
                return new int[0];
            }

            int[] result = new int[array.Length * array.Length];
            Position position = new Position(0, 0, 0, array.GetUpperBound(0));

            for (int i = 0; i < result.Length; i++)
            {
                result.SetValue(array[position.Row][position.Column], i);
                position.MoveToNext();
            }

            return result;
        }

        private class Position
        {
            public Position(int row, int column, int lowerBound, int upperBound)
            {
                Row = row;
                Column = column;
                LowerBound = lowerBound;
                UpperBound = upperBound;
            }

            public int Row { get; private set; }

            public int Column { get; private set; }

            public int LowerBound { get; private set; }

            public int UpperBound { get; private set; }

            private Direction CurrentDirection { get; set; }

            internal void MoveToNext()
            {
                if (Row != UpperBound && Column == UpperBound && CurrentDirection == Direction.Right)
                {
                    MoveDown();
                }
                else if (Row == UpperBound && Column == UpperBound && CurrentDirection == Direction.Down)
                {
                    MoveLeft();
                }
                else if (Row == UpperBound && Column == LowerBound && CurrentDirection == Direction.Left)
                {
                    MoveUp();
                    LowerBound++;
                    UpperBound--;
                }
                else if (Row == LowerBound && CurrentDirection == Direction.Up)
                {
                    MoveRight();
                }
                else
                {
                    RepeatDirection();
                }
            }

            private void RepeatDirection()
            {
                switch (CurrentDirection)
                {
                    case Direction.Right: MoveRight(); break;
                    case Direction.Down: MoveDown(); break;
                    case Direction.Left: MoveLeft(); break;
                    case Direction.Up: MoveUp(); break;
                    default: throw new System.Exception("Cannot repeat direction");
                }
            }

            private void MoveRight()
            {
                Column++;
                CurrentDirection = Direction.Right;
            }

            private void MoveDown()
            {
                Row++;
                CurrentDirection = Direction.Down;
            }

            private void MoveLeft()
            {
                Column--;
                CurrentDirection = Direction.Left;
            }

            private void MoveUp()
            {
                Row--;
                CurrentDirection = Direction.Up;
            }

            private enum Direction
            {
                Right, Down, Left, Up
            }
        }
    }
}

/* Snail
Snail Sort
Given an n x n array, return the array elements arranged from outermost elements to the middle element, traveling clockwise.

array = [[1,2,3],
         [4,5,6],
         [7,8,9]]
snail(array) #=> [1,2,3,6,9,8,7,4,5]
For better understanding, please follow the numbers of the next array consecutively:

array = [[1,2,3],
         [8,9,4],
         [7,6,5]]
snail(array) #=> [1,2,3,4,5,6,7,8,9]
This image will illustrate things more clearly:

NOTE: The idea is not sort the elements from the lowest value to the highest; the idea is to traverse the 2-d array in a clockwise snailshell pattern.
NOTE 2: The 0x0 (empty matrix) is represented as en empty array inside an array [[]].
*/
