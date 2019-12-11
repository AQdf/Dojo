using System.Text;
using System.Linq;
using System;
using System.Collections.Generic;

namespace Sho.Dojo.Katas
{
    public class PlayWithTwoStrings
    {
        public string workOnStrings(string a, string b)
        {
            var letters = a.ToUpperInvariant()
                .Distinct()
                .Where(l => b.Contains(l, StringComparison.InvariantCultureIgnoreCase))
                .ToArray();

            return SwapCasing(b, a, letters) + SwapCasing(a, b, letters);
        }

        private string SwapCasing(string searchStr, string replaceStr, IReadOnlyCollection<char> letters)
        {
            StringBuilder builder = new StringBuilder(replaceStr);

            foreach (char letter in letters)
            {
                int count = searchStr.Count(l => char.ToUpperInvariant(l) == letter);

                if (count % 2 == 1)
                {
                    SwapLetterCasing(letter, replaceStr, builder);
                }
            }

            return builder.ToString();
        }

        private void SwapLetterCasing(char letter, string replaceStr, StringBuilder builder)
        {
            int index = replaceStr.IndexOf(letter, StringComparison.InvariantCultureIgnoreCase);

            while (index != -1)
            {
                builder[index] = char.IsUpper(builder[index]) ? char.ToLowerInvariant(builder[index]) : char.ToUpperInvariant(builder[index]);
                index = replaceStr.IndexOf(letter.ToString(), index + 1, StringComparison.InvariantCultureIgnoreCase);
            }
        }
    }
}

/* Play with two Strings
Your task is to Combine two Strings. But consider the rule...
By the way you don't have to check errors or incorrect input values,
every thing is ok without bad tricks, only two input strings and as result one output string;-)...
And here's the rule:
Input Strings 'a' and 'b': For every character in string 'a' swap the casing of every occurance of the same character in string 'b'.
Then do the same casing swap with the inputs reversed.
Return a single string consisting of the changed version of 'a' followed by the changed version of 'b'.
A char of 'a' is in 'b' regardless if it's in upper or lower case - see the testcases too.
I think that's all;-)...

Some easy examples:

Input: "abc" and "cde"      => Output: "abCCde" 
Input: "abab" and "bababa"  => Output: "ABABbababa"
Input: "ab" and "aba"        => Output: "aBABA"
There are some static tests at the beginning and many random tests if you submit your solution.
*/
