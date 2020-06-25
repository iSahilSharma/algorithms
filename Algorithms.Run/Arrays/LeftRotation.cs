using System;

namespace Algorithms.Arrays
{
    /// Arrays: Left Rotation
    /// Given an array a of n integers and a number, d, perform d left rotations on the array. 
    /// Return the updated array to be printed as a single line of space-separated integers.
    /// 
    /// Print a single line of  space-separated integers denoting the final state of the array after performing  left rotation
    /// Input: 
    /// 4
    /// 1 2 3 4 5
    /// Output
    /// 5 1 2 3 4
    ///
    /// Things to remember: There is a trick to rotate the array by k steps towards LEFT SIDE.
    /// This approach is based on the fact that when we iterate the array 2 times, 
    /// First we iterate the array from rotation steps to length and fill the new array from start with elements and retain the counter.
    /// Second we iterate the array from 0 to total rotation steps and fill the new array from remaining items using the counter

    /// Let n = 7 and k = 3
    /// Original List                   : 1 2 3 4 5 6 7
    /// After first iteration           : 4 5 6 7 0 0 0
    /// After second iteration          : 4 5 6 7 1 2 3  --> Result
    static class LeftRotation
    {
        static int[] Rotate(int[] arr, int rotations)
        {
            int length = arr.Length;
            int[] newArr = new int[length];

            int counter = 0;
            int rotationCount = rotations;

            //First Iteration from rotations to length
            while (rotationCount < length)
            {
                newArr[counter] = arr[rotationCount];
                counter++;
                rotationCount++;
            }

            rotationCount = 0;
            //Reset the rotation count and Second Iteration
            while (rotationCount < rotations)
            {
                newArr[counter] = arr[rotationCount];
                counter++;
                rotationCount++;
            }

            return newArr;
        }
    }

}