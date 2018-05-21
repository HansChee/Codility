/**
 * https://app.codility.com/programmers/lessons/4-counting_elements/missing_integer/
 * */

namespace Codility.Algorithm.CountingElements
{
    public partial class Solution
    {
        public static int MissingInteger(int[] A)
        {
            bool[] B = new bool[A.Length + 1];

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > 0 && A[i] <= A.Length && !B[A[i]])
                {
                    B[A[i]] = true;
                }
            }

            for (int j = 1; j < B.Length; j++)
            {
                if (!B[j])
                {
                    return j;
                }
            }
            return B.Length;
        }
    }
}
