/**
 * https://app.codility.com/programmers/lessons/4-counting_elements/max_counters/
 * */

using System;

namespace Codility.Algorithm.CountingElements
{
    public partial class Solution
    {
        public int[] MaxCounters(int N, int[] A)
        {
            int[] counters = new int[N];

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] <= N)
                {
                    counters[A[i] - 1]++;
                }
                else
                {
                    SetMaxValue(counters);
                }
            }

            return counters;
        }

        private static void SetMaxValue(int[] srcArray)
        {
            int result = 0;
            for (int i = 0; i < srcArray.Length; i++)
            {
                if (srcArray[i]>result)
                {
                    result = srcArray[i];
                }
            }

            for (int i = 0; i < srcArray.Length; i++)
            {
                srcArray[i] = result;
            }
        }
    }
}
