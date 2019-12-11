using System.Collections.Generic;
using System.Linq;

namespace Sho.Dojo.Katas
{
    public class SortOneThreeTwo
    {
        public static int[] Sort(int[] array)
        {
            return array
                .Select(num => new KeyValuePair<string, int>(ToText(num, 100, string.Empty), num))
                .OrderBy(x => x.Key)
                .Select(x => x.Value)
                .ToArray();
        }

        private static string ToText(int num, int divisor, string result)
        {
            if (numbersNames.ContainsKey(num))
            {
                return result += numbersNames[num];
            }

            int key = num / divisor * divisor;
            divisor /= 10;
            num -= key;

            return key > 0 && numbersNames.ContainsKey(key)
                ? (result += numbersNames[key] + " " + ToText(num, divisor, result))
                : ToText(num, divisor, result);
        }

        private static readonly Dictionary<int, string> numbersNames = new Dictionary<int, string>
        {
            { 0, "zero" }, { 1, "one" }, { 2, "two" }, { 3, "three" }, { 4, "four" }, { 5, "five" }, { 6, "six" }, { 7, "seven" }, { 8, "eight" }, { 9, "nine" },
            { 10, "ten" }, { 11, "eleven" }, { 12, "twelve" }, { 13, "thirteen" }, { 14, "fourteen" }, { 15, "fifteen" }, { 16, "sixteen" }, { 17, "seventeen" }, { 18, "eighteen" }, { 19, "nineteen" },
            { 20, "twenty" }, { 30, "thirty" }, { 40, "forty" }, { 50, "fifty" }, { 60, "sixty" }, { 70, "seventy" }, { 80, "eighty" }, { 90, "ninety" },
            { 100, "one hundred" }, { 200, "two hundreds" }, { 300, "three hundreds" }, { 400, "four hundreds" }, { 500, "five hundreds" }, { 600, "six hundreds" }, { 700, "seven hundreds" }, { 800, "eight hundreds" }, { 900, "nine hundreds" }
        };
    }
}

/* Sort - one, three, two
Hey You !
Sort these integers for me ...
By name ...
Do it now !

Input
Range is 0-999

There may be duplicates
The array may be empty

Example
Input: 1, 2, 3, 4
Equivalent names: "one", "two", "three", "four"
Sorted by name: "four", "one", "three", "two"
Output: 4, 1, 3, 2
*/
