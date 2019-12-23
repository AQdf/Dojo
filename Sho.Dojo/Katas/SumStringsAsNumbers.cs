using System.Numerics;

namespace Sho.Dojo.Katas
{
    public class SumStringsAsNumbers
    {
        public static string sumStrings(string a, string b)
        {
            return (BigInteger.Parse(!string.IsNullOrWhiteSpace(a) ? a : "0") + BigInteger.Parse(!string.IsNullOrWhiteSpace(b) ? b : "0")).ToString();
        }
    }
}

/* Sum Strings as Numbers
Given the string representations of two integers, return the string representation of the sum of those integers.

For example: sumStrings('1','2') // => '3'

A string representation of an integer will contain no characters besides the ten numerals "0" to "9".
 */
