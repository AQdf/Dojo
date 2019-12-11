using System.Collections.Generic;
using System.Linq;

namespace Sho.Dojo.Katas
{
    public class SortTheOdd
    {
        public static int[] SortArray(int[] array)
        {
            IOrderedEnumerable<int> oddsArray = array.Where(x => x % 2 == 1).OrderBy(x => x);
            Queue<int> queue = new Queue<int>(oddsArray);

            int[] result = array
                .Select(x => x % 2 == 1 ? queue.Dequeue() : x)
                .ToArray();

            return result;
        }
    }
}

/* Sort the odd
You have an array of numbers.
Your task is to sort ascending odd numbers but even numbers must be on their places.
Zero isn't an odd number and you don't need to move it. If you have an empty array, you need to return it.
Example:
sortArray([5, 3, 2, 8, 1, 4]) == [1, 3, 2, 8, 5, 4]
 */
