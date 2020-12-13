using System;

namespace Algorithms.Arrays
{
    /// Given a fixed length array of integers, duplicate each occurrence of zero, shifting the remaining elements to the right.
    /// Input: [1,0,2,3,0,4,5,0]
    /// Output: [1,0,0,2,3,0,0,4]
    /// Constraints
    /// You must do this in-place without making a copy of the array.
    /// Minimize the total number of operations.
    /// 1 <= arr.length <= 10000
    /// 0 <= arr[i] <= 9
    ///
    /// Things to remember: 
    static class DuplicateZeroes
    {
        public static int[] Perform(int[] arr)
        {
            int length = arr.Length;
            for (int i = 0; i < length; i++)
            {
                if (arr[i] == 0)
                {
                    for (int j = length - 1; j > i; j--)
                    {
                        arr[j] = arr[j - 1];
                    }

                    i++;
                }
            }

            return arr;
        }
    }
}