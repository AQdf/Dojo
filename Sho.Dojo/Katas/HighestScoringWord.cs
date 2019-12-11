using System.Linq;

namespace Sho.Dojo.Katas
{
    public class HighestScoringWord
    {
        private static readonly string _alphabet = "abcdefghijklmnopqrstuvwxyz";

        // Best solution. Not dependant on ascii order
        public static string High(string s)
        {
            string[] words = s.Split(" ");

            return words.OrderByDescending(word => word.Sum(l => _alphabet.IndexOf(l) + 1)).First();
        }

        // Cleaniest solution
        //public static string High(string s) => s.Split(' ').OrderByDescending(w => w.Sum(c => c - 'a' + 1)).First();

        // My Solution
        //public static string High(string s)
        //{
        //    string[] words = s.Split(" ");

        //    return words.Aggregate(new { word = string.Empty, score = 0 }, 
        //        (seed, word) => {
        //            int score = word.Sum(l => _alphabet.IndexOf(l) + 1);
        //            return score > seed.score ? new { word, score } : seed;
        //        },
        //        wordScore => wordScore.word);
        //}
    }
}

/* Highest Scoring Word
Given a string of words, you need to find the highest scoring word.
Each letter of a word scores points according to its position in the alphabet: a = 1, b = 2, c = 3 etc.
You need to return the highest scoring word as a string.
If two words score the same, return the word that appears earliest in the original string.
All letters will be lowercase and all inputs will be valid.
*/
