using System;

namespace Algorithms.Arrays
{
    /// Maximum Consecutive Items - Given a binary array, find the maximum number of consecutive 1s (or 0s) in this array.
    ///
    /// Input: [1,1,0,1,1,1]
    /// Output: 3
    /// Explanation: The first two digits or the last three digits are consecutive 1s. The maximum number of consecutive 1s is 3.
    ///
    /// Things to remember: To find the length of consecutive numbers, 
    static class MaxConsecutiveItems
    {
        public static int Count(int[] arr, int item)
        {
            int length = arr.Length;
            int subsetOfArray = 0;    // Take the consecutive items in a variable.
            int maxLength = 0;        // Take the maximum length of the subset of array.

            for (int i = 0; i < length; i++)
            {
                // Check if the item matches the requested element, increment until other element comes
                if (arr[i] == item)
                {
                    subsetOfArray++;
                }
                else
                {
                    // If the length of subset is greater than existing max length, override the max length
                    if (subsetOfArray > maxLength)
                    {
                        maxLength = subsetOfArray;
                    }

                    subsetOfArray = 0;
                }
            }

            // Return the result based on either the current subset array is greater or the existing max length
            // return Math.Max(maxLength, subsetOfArray);  // We can either use the Math.Max() or ?: to compare two values
            return (maxLength > subsetOfArray) ? maxLength : subsetOfArray;
        }
    }
}