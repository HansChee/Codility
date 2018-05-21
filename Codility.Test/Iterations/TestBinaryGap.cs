using Codility.Algorithm.Iterations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codility.Test.Iterations
{
    [TestClass]
    public class TestBinaryGap
    {
        int N;
        int gap;
        Solution solution = new Solution();

        [TestMethod]
        public void TestExample1()
        {
            // range
            N = 1041;

            // excute
            gap = solution.BinaryGap(N);

            // compare
            Assert.AreEqual(5, gap);
        }

        [TestMethod]
        public void TestExample2()
        {
            N = 15;

            gap = solution.BinaryGap(N);

            Assert.AreEqual(0, gap);
        }

        [TestMethod]
        public void TestExtreme()
        {
            // range
            N = 2147483647;

            // excute
            gap = solution.BinaryGap(N);

            // compare
            Assert.AreEqual(0, gap);
        }

        [TestMethod]
        public void TestLarge()
        {
            // range
            N = 1610612737;

            // excute
            gap = solution.BinaryGap(N);

            // compare
            Assert.AreEqual(28, gap);
        }
    }
}
