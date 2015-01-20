﻿using System;
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

    }
}