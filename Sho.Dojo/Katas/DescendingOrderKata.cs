using System.Linq;

namespace Sho.Dojo.Katas
{
    public class DescendingOrderKata
    {
        public static long DescendingOrder(long num)
        {
            if (num < 0)
            {
                return num;
            }

            string numString = num.ToString();
            string orderedNumString = string.Concat(numString.OrderByDescending(c => c));

            return long.Parse(orderedNumString);
        }
    }
}

/*
Your task is to make a function that can take any non-negative integer as a argument
and return it with its digits in descending order.
Essentially, rearrange the digits to create the highest possible number.

Examples:
Input: 21445 Output: 54421
Input: 145263 Output: 654321
Input: 1254859723 Output: 9875543221
*/
