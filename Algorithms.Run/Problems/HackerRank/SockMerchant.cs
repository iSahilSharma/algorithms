using System;
using System.Collections;
using System.Collections.Generic;

namespace Algorithms.HackerRank
{
    /// <summary>
    /// Sock Merchant Problem - Given an array of integers representing the color of each sock, determine how many pairs of socks with matching colors there are.
    /// For example, there are n=7 socks with colors arr=[1,2,1,2,1,3,2]. There is one pair of color 1 and one of color 2. 
    /// There are three odd socks left, one of each color. The number of pairs is 2.
    ///
    /// Things to Remember - HashSet<T> is a generic class to store unordered unique values.
    /// </summary>
    static class SockMerchant
    {
        // n = 9
        // arr = [10, 20, 20, 10, 10, 30, 50, 10, 20]
        public static int CountSockPair(int n, int[] arr)
        {
            HashSet<int> set = new HashSet<int>();
            int count = 0;

            if (arr.Length == 0)
                return count;

            for (int i = 0; i < n; i++)
            {
                if (set.Contains(arr[i]))
                {
                    count++;
                    set.Remove(arr[i]);
                }
                else
                {
                    set.Add(arr[i]);
                }
            }

            return count;
        }

    }
}