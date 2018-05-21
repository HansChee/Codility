/**
 * https://app.codility.com/programmers/lessons/4-counting_elements/frog_river_one/
 * */

namespace Codility.Algorithm.CountingElements
{
    public partial class Solution
    {
        public int FrogRiverOne(int X, int[] A)
        {
            bool[] B = new bool[X + 1];

            for (int i = 0; i < A.Length; i++)
            {
                if (!B[A[i]])
                {
                    B[A[i]] = true;
                    X--;
                    if (X == 0)
                    {
                        return i;
                    }
                }
            }

            return -1;
        }
    }
}
