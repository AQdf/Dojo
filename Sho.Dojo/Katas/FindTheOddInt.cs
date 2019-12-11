using System.Linq;

namespace Sho.Dojo.Katas
{
    public class FindTheOddInt
    {
        public static int find_it(int[] seq)
        {
            return seq.GroupBy(x => x).Single(x => x.Count() % 2 == 1).Key;
        }
    }

    // If you will xor 0 and any integer even times you will get 0. But if you will xor 0 and integer odd times then you will get your integer.
    //public static int find_it(int[] seq)
    //{
    //    int found = 0;

    //    foreach (var num in seq)
    //    {
    //        found ^= num;
    //    }

    //    return found;
    //}
}

/* Find the odd int
Given an array, find the int that appears an odd number of times.
There will always be only one integer that appears an odd number of times.
*/
