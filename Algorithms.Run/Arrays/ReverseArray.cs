using System;

namespace Algorithms.Arrays
{
    /// Arrays: Reverse Rotation
    /// Given an array, reverse the array.
    /// Input: nums = [1,2,3,4,5,6,7] 
    /// Output: [7,6,5,4,3,2,1]
    ///
    /// Things to remember
    static class ReverseArray
    {
        public static int[] Perform(int[] arr)
        {
            int length = arr.Length;
            if (length < 2) return arr;

            int start = 0;
            int end = length - 1;
            while (start < end)
            {
                int temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;

                start++;
                end--;
            }

            return arr;
        }
    }
}