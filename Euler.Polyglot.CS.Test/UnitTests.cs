using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Euler.Polyglot;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;

namespace Euler.Polyglot.CS.Test
{
    [TestClass]
    public class TestProblems
    {
        [TestMethod]
        public void TestMethod1()
        {
            var p1 = new Problem1();
            var sum = p1.SumArray(p1.FindMultiples(10, new int[] { 3, 5 }));
            sum = p1.SumArray(p1.FindMultiples(1000, new int[] { 3, 5 })); 
        }

        [TestMethod]
        public void Problem2Test()
        {
            var p2 = new Problem2();
            var sum = p2.FibonnaciSum(4000000);
        }

        [TestMethod]
        public void Problem3Test()
        {
            var p3 = new Problem3();
            List<long> res = p3.FindPrimes(13195/2);
            res = p3.FindFactors(res, 13195);
            var largestPrimeFactor = res[res.Count-1];
            Assert.AreEqual(largestPrimeFactor, 29);

            //heuristics - 600851475143/2 is even hence 300425737572 non-prime
            //sqrt ()= 775146
            //var val = BigInteger.Pow (600851475143, 1/2).ToString((type)BigInteger);
            res = p3.FindPrimes(775147);
            res = p3.FindFactors(res, 600851475143);
            largestPrimeFactor = res[res.Count - 1];
            Assert.AreEqual(largestPrimeFactor, 6857);
        }

        [TestMethod]
        public void Problem4Test()
        {
            var p4 = new Problem4();
            var list = p4.FindLargestPalindrome();
        }

        [TestMethod]
        public void Problem5Test()
        {
            var p5 = new Problem5();
            var res= p5.FindLargestDivisor(10); //2520
            res = p5.FindLargestDivisor(20); //232792560
        }

        [TestMethod]
        public void Problem6Test()
        {
            var p6 = new Problem6();
            var s1 = p6.SumOfSquares(Enumerable.Range(1, 10).Select(x => x));
            var s2 = p6.SquareOfSum(Enumerable.Range(1, 10).Select(x => x));
            Assert.AreEqual(s2 - s1, 2640);

            s1 = p6.SumOfSquares(Enumerable.Range(1, 100).Select(x => x));
            s2 = p6.SquareOfSum(Enumerable.Range(1, 100).Select(x => x));
            Assert.AreEqual(s2 - s1, 25164150);
                   
        }


        [TestMethod]
        public void Problem7Test()
        {
            var p7 = new Problem7();
            var res = p7.GetNthPrime(6);
            Assert.AreEqual(res, 13);

            res = p7.GetNthPrime(10001);
            Assert.AreEqual(res, 104743);

            
        }

    }
}
