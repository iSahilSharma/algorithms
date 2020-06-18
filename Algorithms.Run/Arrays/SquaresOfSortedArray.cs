using System;

namespace Algorithms.Arrays
{
    /// Squares of Sorted Array - Given an array of integers sorted in non-decreasing order, return an array of the squares of each number, also in sorted non-decreasing order.
    /// Consider the example:
    /// Input: [-4,-1,0,3,10]
    /// Output: [0,1,9,16,100]
    /// Constraints:
    /// 1 <= A.length <= 10000
    /// -10000 <= A[i] <= 10000
    /// A is sorted in non-decreasing order.
    ///
    /// Things to remember: To solve the problem, we have two options
    /// 1. We can iterate the array to square all elements and then sort using Array.Sort(). This is simple but the space and time complexity is higher. 
    /// 2. We can start from end of the array and add squares of elements by comparing the first and last element, replace the greater element at the end of the array. 
    ///    This takes only one loop and hence efficient in time complexity.
    static class SquaresOfSortedArray
    {
        public static int[] GetSortedArrayUsingFirstApproach(int[] arr)
        {
            int length = arr.Length;
            int[] sortedArray = new int[length];

            for (int i = 0; i < length; i++)
            {
                sortedArray[i] = arr[i] * arr[i];
            }

            Array.Sort(sortedArray);
            return sortedArray;
        }

        public static int[] GetSortedArrayUsingSecondApproach(int[] arr)
        {
            int length = arr.Length;
            int[] sortedArray = new int[length];
            int left = 0;            // Starting point of the array
            int right = length - 1;  // End of the array

            for (int i = length - 1; i >= 0; i--)
            {
                if (Math.Abs(arr[left]) > arr[right])   //Compare the absolute values, first and last elements. Even for -ve numbers, squares are always positive
                {
                    sortedArray[i] = arr[left] * arr[left];  //Put the squared number
                    left++;
                }
                else
                {
                    sortedArray[i] = arr[right] * arr[right];
                    right--;
                }
            }

            return sortedArray;
        }
    }
}