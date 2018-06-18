/**
 * https://app.codility.com/programmers/lessons/5-prefix_sums/passing_cars/
 * */

using System;

namespace Codility.Algorithm.PrefixSums
{
    public partial class Solution
    {
        public int PassingCars(int[] A)
        {
            long result = 0;
            long sum = 0;
            for (int i = 0; i < A.Length; i++)
            {
                sum += A[i];
            }
            long subSum = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == 0)
                {
                    result += sum - subSum;
                    if (result > 1000000000)
                    {
                        return -1;
                    }
                }
                else if (A[i] == 1)
                {
                    subSum++;
                }
            }
            return (int)result;
        }
    }
}
