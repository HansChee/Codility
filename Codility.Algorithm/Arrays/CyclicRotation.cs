/**
 * https://app.codility.com/programmers/lessons/2-arrays/cyclic_rotation/
 */

namespace Codility.Algorithm.Arrays
{
    public partial class Solution
    {
        public static int[] CyclicRotation(int[] A, int K)
        {
            if (A?.Length > 0)
            {
                int[] B = new int[A.Length];

                int beginIndex = 0;

                for (; K > 0; K--)
                {
                    beginIndex--;
                    if (beginIndex < 0)
                    {
                        beginIndex = A.Length - 1;
                    }
                }

                for (int i = 0; i < A.Length; i++)
                {
                    B[i] = A[beginIndex];

                    beginIndex++;
                    if (beginIndex > A.Length - 1)
                    {
                        beginIndex = 0;
                    }
                }

                return B;
            }
            return A;
        }
    }
}
