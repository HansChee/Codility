/**
 * https://app.codility.com/programmers/lessons/3-time_complexity/tape_equilibrium/
 */

using System;
using System.Linq;

namespace Codility.Algorithm.TimeComplexity
{
    public partial class Solution
    {
        public static int TapeEquilibrium(int[] A)
        {
            var sum = A.Sum();
            int minSum = 0;
            int currentSum = 0;

            for (int i = 1; i < A.Length; i++)
            {
                currentSum += A[i - 1];

                var tempValue = Math.Abs(2 * currentSum - sum);

                if (i == 1 || tempValue < minSum)
                {
                    minSum = tempValue;
                }
            }

            return minSum;
        }

    }
}
