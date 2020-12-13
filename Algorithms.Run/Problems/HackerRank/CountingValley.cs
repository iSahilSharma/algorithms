using System;

namespace Algorithms.HackerRank
{
    /// <summary>
    /// Counting Valleys Problem - Given Gary's sequence of up and down steps during his last hike, find and print the number of valleys he walked through.
    /// We define the following terms:
    /// A mountain is a sequence of consecutive steps above sea level, starting with a step up 'U' from sea level and ending with a step down to sea level.
    /// A valley is a sequence of consecutive steps below sea level, starting with a step down 'D" from sea level and ending with a step up to sea level.
    /// For example, if Gary's path is s = [DDUUUUDD], he first enters a valley 2 units deep. Then he climbs out an up onto a mountain 2 units high. 
    /// Finally, he returns to sea level and ends his hike. 
    /// Complete the countingValleys function in the editor below. It must return an integer that denotes the number of valleys Gary traversed.
    /// counting Valleys has the following parameter(s):
    /// n: the number of steps Gary takes
    /// s: a string describing his path
    ///
    /// Print a single integer that denotes the number of valleys Gary walked through during his hike.
    /// Sample Input
    /// 8
    /// UDDDUDUU
    ///
    /// Things to Remember 
    /// </summary>
    static class CountingValley
    {
        public static int Count(int n, string sentence)
        {
            int altitude = 0;
            int sealevel = 0;

            for (int i = 0; i < n; i++)
            {
                if (sentence[i] == 'U')
                {
                    altitude++;
                }
                else if (sentence[i] == 'D')
                {
                    if (altitude == 0)
                    {
                        sealevel++;
                    }

                    altitude--;
                }
            }

            return sealevel;
        }
    }
}