using Codility.Algorithm.CountingElements;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Codility.Test.CountingElements
{
    [TestClass]
    public class TestMissingInteger
    {
        int[] A;
        Solution solution = new Solution();

        [TestMethod]
        public void TestSample()
        {
            A = new int[] { 1, 3, 6, 4, 1, 2 };

            var result = solution.MissingInteger(A);

            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void TestSample1()
        {
            A = new int[] { 1, 2, 3 };

            var result = solution.MissingInteger(A);

            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void TestSample2()
        {
            A = new int[] { -1, -3 };

            var result = solution.MissingInteger(A);

            Assert.AreEqual(1, result);
        }
    }
}
