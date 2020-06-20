using System;

namespace Algorithms.Arrays
{
    /// Move all zeroes to the right.
    /// Given an array, write a function to move all 0's to the end of it while maintaining the relative order of the non-zero elements.
    /// Input: [0,1,0,3,12]
    /// Output: [1,3,12,0,0]
    /// Constraints
    /// You must do this in-place without making a copy of the array.
    /// Minimize the total number of operations.
    ///
    /// Things to remember: 
    static class MoveZeroes
    {
        // We can first shift the non-zero elements to left and counting the shifts. When all the non-zeroes are shifted, update the remaining indices with 0s.
        public static int[] Perform(int[] arr)
        {
            int length = arr.Length;
            int shiftCounter = 0;

            if (length <= 1) return arr;

            for (int i = 0; i < length; i++)
            {
                if (arr[i] != 0)  //If the element is non-zero, move it to left(initially the shift counter = 0 means extreme left) and increase the shift counter.
                {
                    arr[shiftCounter] = arr[i];
                    shiftCounter++;
                }
            }

            //When all the non-zeroes are sorted, update the remaining indices with zeroes by checking the counter.
            while (shiftCounter < length)
            {
                arr[shiftCounter] = 0;
                shiftCounter++;
            }

            return arr;
        }
    }

}