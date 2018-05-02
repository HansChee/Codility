using Codility.Algorithm.CountingElements;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Codility.Test.CountingElements
{
    [TestClass]
    public class TestFrogRiverOne
    {
        int[] A;
        int X;

        [TestMethod]
        public void TestSample()
        {
            X = 5;
            A = new int[] { 1, 3, 1, 4, 2, 3, 5, 4 };

            var result = Solution.FrogRiverOne(X, A);

            //Assert.AreEqual()
        }
    }
}
