using Codility.Algorithm.Arrays;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Codility.Test.Arrays
{
    [TestClass]
    public class TestOddOccurrencesInArray
    {
        int[] A;
        Solution solution = new Solution();

        [TestMethod]
        public void TestSample()
        {
            A = new int[] { 4, 7, 4, 5, 7 };

            var result = solution.OddOccurrencesInArray(A);

            Assert.AreEqual(5, result);
        }
    }
}
