using System;

namespace Algorithms.HackerRank
{
    /// <summary>
    /// Repeated String Problem - A string, s, of lowercase English letters that has been repeated infinitely many times. 
    /// Given an integer, n, find and print the number of letter a's in the first n letters of infinite string.
    /// For example, if the string s="abcac" and n=10, the substring we consider is abcacabcac, the first 10 characters of her infinite string. 
    /// There are 4 occurrences of a in the substring.
    ///
    /// Complete the repeatedString function below. 
    /// It should return an integer representing the number of occurrences of a in the prefix of length in the infinitely repeating string.
    /// repeatedString has the following parameter(s):
    /// s: a string to repeat
    /// n: the number of characters to consider
    ///
    /// Things to Remember - Modulus & Division 
    /// </summary>
    static class RepeatedString
    {
        public static long CountRepeatedCharacters(string sentence, int n)
        {
            long lengthOfString = sentence.Length;             // Length of string
            long numOfSubstrReq = n / lengthOfString;          // Number of substring required
            long numOfCharNotDivisible = n % lengthOfString;   // Improper division value incase the modulus is non-zero
            long repString = 0;                                // Number of repeated strings

            for (int i = 0; i < lengthOfString; i++)
            {
                if (sentence[i] == 'a')
                {
                    repString++;
                }
            }

            long total = repString * numOfSubstrReq;

            //Incase the modulus is non-zero, we need to find the 'a' in that substring
            if (numOfCharNotDivisible > 0)
            {
                for (int j = 0; j < numOfCharNotDivisible; j++)
                {
                    if (sentence[j] == 'a')
                    {
                        total++;
                    }
                }
            }

            return total;
        }
    }
}
