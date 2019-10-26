using System;
using System.Text;

namespace Sho.Dojo.Katas
{
    public class PrimesInNumbers
    {
        public static string Factors(int number)
        {
            if (number == 1)
            {
                return string.Empty;
            }

            StringBuilder builder = new StringBuilder();
            int quotient = number;
            int prime = 2;
            int factor = 0;

            while (quotient != 1)
            {
                if (quotient % prime == 0)
                {
                    quotient /= prime;
                    factor++;
                }
                else
                {
                    builder.Append(GetFormattedPart(prime, factor));
                    prime = GetNextPrimeNumber(prime);
                    factor = 0;
                }

                if (quotient == 1)
                {
                    builder.Append(GetFormattedPart(prime, factor));
                }
            }

            return builder.ToString();
        }

        public static string GetFormattedPart(int prime, int factor)
        {
            string result = string.Empty;

            if (factor == 1)
            {
                result = $"({prime})";
            }
            else if (factor > 1)
            {
                result = $"({prime}**{factor})";
            }

            return result;
        }

        public static int GetNextPrimeNumber(int current)
        {
            if (current == 2)
            {
                return 3;
            }

            bool found;
            int number = current;

            do
            {
                number+=2;

                for (int i = 2; i < Math.Sqrt(number); i++)
                {
                    if (number % i == 0)
                    {
                        break;
                    }
                }

                found = true;
            }
            while (!found);

            return number;
        }
    }
}

/* Primes in numbers
Given a positive number n > 1 find the prime factor decomposition of n.
The result will be a string with the following form :
    "(p1**n1)(p2**n2)...(pk**nk)"
with the p(i) in increasing order and n(i) empty if n(i) is 1.

Example: n = 86240 should return "(2**5)(5)(7**2)(11)"
*/
