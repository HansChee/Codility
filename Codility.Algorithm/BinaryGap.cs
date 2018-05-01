/**
 * https://app.codility.com/programmers/lessons/1-iterations/
 */

using System;

namespace Codility.Algorithm
{
    public partial class Solution
    {
        public static int BinaryGap(int N)
        {
            if (N <= 0)
            {
                throw new ArgumentOutOfRangeException("N must be a positive integer.");
            }

            var NBinary = Convert.ToString(N, 2);

            var count = 0;
            var tempCount = 0;

            foreach (var item in NBinary)
            {
                switch (item)
                {
                    case '1':
                        if (tempCount > count)
                        {
                            count = tempCount;
                        }
                        tempCount = 0;
                        break;
                    case '0':
                        tempCount++;
                        break;
                }
            }

            return count;
        }
    }
}
