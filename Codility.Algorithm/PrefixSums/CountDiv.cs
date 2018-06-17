/**
* https://app.codility.com/programmers/lessons/5-prefix_sums/count_div/
* */


namespace Codility.Algorithm.PrefixSums
{
    public partial class Solution
    {
        public int CountDiv(int A, int B, int K)
        {
            int result = 0;

            while (true)
            {
                if (A > B)
                {
                    break;
                }
                if (A % K == 0)
                {
                    result++;
                    A += K;
                }
                else
                {
                    A++;
                }
            }

            return result;
        }
    }
}
