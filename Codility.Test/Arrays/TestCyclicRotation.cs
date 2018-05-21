using Codility.Algorithm.Arrays;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Codility.Test.Arrays
{
    [TestClass]
    public class TestCyclicRotation
    {
        int[] A;
        int K;
        Solution solution = new Solution();

        [TestMethod]
        public void TestExample()
        {
            A = new int[] { 3, 8, 9, 7, 6 };
            K = 3;

            var result = Enumerable.SequenceEqual(solution.CyclicRotation(A, K), new int[] { 9, 7, 6, 3, 8 });

            Assert.IsTrue(result);


            A = new int[] { 0, 0, 0 };
            K = 1;

            result = Enumerable.SequenceEqual(solution.CyclicRotation(A, K), new int[] { 0, 0, 0 });

            Assert.IsTrue(result);

            A = new int[] { 1, 2, 3, 4 };
            K = 4;

            result = Enumerable.SequenceEqual(solution.CyclicRotation(A, K), new int[] { 1, 2, 3, 4 });

            Assert.IsTrue(result);
        }
    }
}
