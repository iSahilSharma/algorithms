using System;

namespace Algorithms.Arrays
{
    /// Arrays: Right Rotation
    /// Given an array, rotate the array to the right by k steps, where k is non-negative.
    /// Input: nums = [1,2,3,4,5,6,7], k = 3
    /// Output: [5,6,7,1,2,3,4]
    /// Explanation:
    /// rotate 1 steps to the right: [7,1,2,3,4,5,6]
    /// rotate 2 steps to the right: [6,7,1,2,3,4,5]
    /// rotate 3 steps to the right: [5,6,7,1,2,3,4]
    ///
    /// Things to remember: There is a trick to rotate the array by k steps towards RIGHT SIDE.
    /// This approach is based on the fact that when we rotate the array k times, 
    /// k elements from the back end of the array come to the front and the rest of the elements from the front shift backwards.
    /// In this approach, we firstly reverse all the elements of the array. 
    /// Then, reversing the first k elements followed by reversing the rest n−k elements gives us the required result.
    /// Let n = 7 and k = 3
    /// Original List                   : 1 2 3 4 5 6 7
    /// After reversing all numbers     : 7 6 5 4 3 2 1
    /// After reversing first k numbers : 5 6 7 4 3 2 1
    /// After revering last n-k numbers : 5 6 7 1 2 3 4 --> Result
    static class RightRotation
    {
        public static int[] Perform(int[] arr, int steps)
        {
            int length = arr.Length;
            steps = steps % length;
            
            Reverse(arr, 0, length - 1);
            Reverse(arr, 0, steps - 1);
            Reverse(arr, steps, length - 1);

            return arr;
        }

        public static void Reverse(int[] nums, int start, int end)
        {
            while (start < end)
            {
                int temp = nums[start];
                nums[start] = nums[end];
                nums[end] = temp;
                start++;
                end--;
            }
        }
    }
}