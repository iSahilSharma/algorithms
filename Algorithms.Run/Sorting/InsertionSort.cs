using System;

namespace Algorithms.Sorting
{
    /// Insertion Sort - Sort items in a specific order using the same way we sort playing cards by our hand.
    /// Input - [9,1,4,6,2,8]
    /// Output - [1,2,4,6,8,9]
    /// Time Complexity: O(n^2)
    /// Space Complexity: O(1)
    static class InsertionSort
    {
        /// The algorithm works in following steps:
        /// Step 1: Iterate the loop till the length of items is less than index.
        /// Step 2: Call the first element of the array "sorted"
        /// Step 3: Repeat for unsorted elements until all elements are sorted.
        /// Step 4: Check for all previous indexes of current index and iterate the inner loop. Eg: If index = 3, iterate for all previous indices 2,1,0.
        public static void Sort(int[] arr)
        {
            int len = arr.Length;

            for (int index = 0; index < len; index++)
            {
                int item = arr[index];

                int previousIndex = index - 1;
                while (previousIndex >= 0 && arr[previousIndex] > item)
                {
                    arr[previousIndex + 1] = arr[previousIndex];
                    previousIndex--;
                }

                arr[previousIndex + 1] = item;
            }

        }
    }
}