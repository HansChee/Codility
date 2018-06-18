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

            int i1 = A / K;
            int i2 = B / K;
            result = i2 - i1 + (A % K == 0 ? 1 : 0);

            return result;
        }
    }
}
