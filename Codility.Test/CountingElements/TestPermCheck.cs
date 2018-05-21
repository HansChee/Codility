using Codility.Algorithm.CountingElements;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Codility.Test.CountingElements
{
    [TestClass]
    public class TestPermCheck
    {
        int[] A;
        Solution solution = new Solution();

        [TestMethod]
        public void TestSampleCase()
        {
            A = new int[] { 4, 1, 3, 2 };

            var result = solution.PermCheck(A);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void TestSampleCase1()
        {
            A = new int[] { 4, 1, 3 };

            var result = solution.PermCheck(A);

            Assert.AreEqual(0, result);
        }
    }
}
