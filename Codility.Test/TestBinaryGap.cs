using Codility.Algorithm;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codility.Test
{
    [TestClass]
    public class TestBinaryGap
    {
        int N;
        int gap;

        [TestMethod]
        public void TestExample1()
        {
            // range
            N = 1041;

            // excute
            gap = Solution.BinaryGap(N);

            // compare
            Assert.AreEqual(5, gap);
        }

        [TestMethod]
        public void TestExample2()
        {
            N = 15;

            gap = Solution.BinaryGap(N);

            Assert.AreEqual(0, gap);
        }

        [TestMethod]
        public void TestExtreme()
        {
            // range
            N = 2147483647;

            // excute
            gap = Solution.BinaryGap(N);

            // compare
            Assert.AreEqual(0, gap);
        }

        [TestMethod]
        public void TestLarge()
        {
            // range
            N = 1610612737;

            // excute
            gap = Solution.BinaryGap(N);

            // compare
            Assert.AreEqual(28, gap);
        }
    }
}
