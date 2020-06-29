using System;

namespace Algorithms.HackerRank
{
    /// Minimum Swaps Problem - Given an unordered array consisting of consecutive integers  [1, 2, 3, ..., n] without any duplicates. 
    /// You are allowed to swap any two elements. You need to find the minimum number of swaps required to sort the array in ascending order.
    /// For example, given the array  we perform the following steps:
    /// Input - [4 3 1 2]
    /// Output - [1,2,3,4], Swaps = 3
    /// Explanation: Given array [4,3,2,1]
    /// After swapping  we get [1,3,4,2]
    /// After swapping  we get [1,4,3,2]
    /// After swapping  we get [1,2,3,4]
    /// So, we need a minimum of 3 swaps to sort the array in ascending order.
    static class MinimumSwaps
    {
        public static int Swap(int[] arr)
        {
            int length = arr.Length;
            int swaps = 0;

            if (length < 2) return swaps;

            for (int i = 0; i < length; i++)
            {
                if (arr[i] == i + 1) continue;

                swaps++;
                int temp = arr[i];
                arr[i] = arr[temp-1];
                arr[temp-1] = temp;
                i--;

            }

            return swaps;

        }
    }

}