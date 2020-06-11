using System;

namespace Algorithms.Common
{
    /// <summary>
    /// Fizz Buzz Problem - Given the following length of numbers as n, find and print each number from 1 to n on a new line.
    /// We define the following terms:
    /// For each multiple of 3, print "Fizz" instead of the number. 
    /// For each multiple of 5, print "Buzz" instead of the number. 
    /// For numbers which are multiples of both 3 and 5, print "FizzBuzz" instead of the number.
    /// For all other numbers, print the number.
    ///
    /// Things to Remember: Modulus Operator - The Modulus is the remainder of the euclidean division of one number by another. % is called the modulo operation.
    /// For instance, 9 divided by 4 equals 2 but it remains 1. Here, 9 / 4 = 2 and 9 % 4 = 1.
    /// For a number to be multiple by another number, the modulus should be 0. For example, multiple of 3 are 3, 6, 9 etc.
    /// </summary>
    static class FizzBuzz
    {
        public static void Print(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}