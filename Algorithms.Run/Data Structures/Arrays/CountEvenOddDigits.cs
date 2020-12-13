using System;

namespace Algorithms.Arrays
{
    /// Count numbers with even or odd digits in an array - Given an array of integers, return how many of them contain an even (or odd) number of digits.
    ///
    /// Input: [12,345,2,6,7896]
    /// Output: 2
    /// Explanation: 
    /// 12 contains 2 digits (even number of digits). 
    /// 345 contains 3 digits (odd number of digits). 
    /// 2 contains 1 digit (odd number of digits). 
    /// 6 contains 1 digit (odd number of digits). 
    /// 7896 contains 4 digits (even number of digits). 
    /// Therefore only 12 and 7896 contain an even number of digits.
    /// Constraints:
    /// 1 <= array.length <= 500
    /// 1 <= array[i] <= 10^5
    ///
    /// Things to remember: 
    /// 1. One way to solve this to convert each item as string and find the modulus of string length for even or odd. This will not work for negative numbers.
    /// 2. If we don't want to convert each item into string, we can see the given constraints that the number will be from 1 - 10^5, we can create a custom method to check it.
    static class CountEvenOddDigits
    {
        public static int CountUsingFirstApproach(int[] arr, string digitType)
        {
            int digitCount = 0;
            int length = arr.Length;

            for (int i = 0; i < length; i++)
            {
                string item = Convert.ToString(arr[i]);

                if (digitType == "Odd")
                {
                    if (item.Length % 2 != 0)
                    {
                        digitCount++;
                    }
                }

                if (digitType == "Even")
                {
                    if (item.Length % 2 == 0)
                    {
                        digitCount++;
                    }
                }
            }

            return digitCount;
        }

        public static int CountUsingSecondApproach(int[] arr, string digitType)
        {
            int digitCount = 0;
            int length = arr.Length;

            for (int i = 0; i < length; i++)
            {
                if (digitType == "Odd")
                {
                    if (CheckIntegerNumberLength(arr[i]) % 2 != 0)
                    {
                        digitCount++;
                    }
                }

                if (digitType == "Even")
                {
                    if (CheckIntegerNumberLength(arr[i]) % 2 == 0)
                    {
                        digitCount++;
                    }
                }
            }

            return digitCount;
        }

        static int CheckIntegerNumberLength(int number)
        {
            if (number > 0)
            {
                if (number < 10) return 1;
                if (number < 100) return 2;
                if (number < 1000) return 3;
                if (number < 10000) return 4;
                if (number < 100000) return 5;
            }
            else
            {
                if (number > -10) return 1;
                if (number > -100) return 2;
                if (number > -1000) return 3;
                if (number > -10000) return 4;
                if (number > -100000) return 5;
            }

            return number;
        }
    }
}