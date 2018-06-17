using Codility.Algorithm.PrefixSums;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codility.Test.PrefixSums
{
    [TestClass]
    public class TestCountDiv
    {
        int A;
        int B;
        int K;

        Solution solution = new Solution();

        [TestMethod]
        public void TestSample()
        {
            A = 6;
            B = 11;
            K = 2;

            var result = solution.CountDiv(A, B, K);

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void TestMyOwnCase()
        {
            A = 8;
            B = 17;
            K = 5;

            var result = solution.CountDiv(A, B, K);

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void TestBigValue()
        {
            A = 0;
            B = int.MaxValue;
            K = int.MaxValue / 2;

            var result = solution.CountDiv(A, B, K);

            Assert.AreEqual(2, result);
        }
    }
}
