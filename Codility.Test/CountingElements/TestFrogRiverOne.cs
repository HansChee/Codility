using Codility.Algorithm.CountingElements;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codility.Test.CountingElements
{
    [TestClass]
    public class TestFrogRiverOne
    {
        int[] A;
        int X;
        Solution solution = new Solution();

        [TestMethod]
        public void TestSample()
        {
            X = 5;
            A = new int[] { 1, 3, 1, 4, 2, 3, 5, 4 };

            var result = solution.FrogRiverOne(X, A);

            Assert.AreEqual(6, result);
        }
    }
}
