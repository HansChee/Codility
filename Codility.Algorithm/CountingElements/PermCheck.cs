/**
 * https://app.codility.com/programmers/lessons/4-counting_elements/perm_check/
 * */

using System;
using System.Collections.Generic;
using System.Text;

namespace Codility.Algorithm.CountingElements
{
    public partial class Solution
    {
        public static int PermCheck(int[] A)
        {
            int[] B = new int[A.Length + 1];
            foreach (var item in A)
            {
                if (item < B.Length)
                {
                    B[item]++;
                }
            }
            for (int i = 1; i < B.Length; i++)
            {
                if (B[i] == 0)
                {
                    return 0;
                }
            }

            return 1;
        }
    }
}
