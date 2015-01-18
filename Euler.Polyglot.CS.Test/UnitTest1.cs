using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Euler.Polyglot;

namespace Euler.Polyglot.CS.Test
{
    [TestClass]
    public class TestProblem1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var p1 = new Problem1();
            var sum = p1.SumArray(p1.FindMultiples(10, new int[] { 3, 5 }));
            sum = p1.SumArray(p1.FindMultiples(1000, new int[] { 3, 5 })); 
        }
    }
}
