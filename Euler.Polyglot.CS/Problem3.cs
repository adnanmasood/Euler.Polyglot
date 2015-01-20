
//Problem 3
//=========
//   The prime factors of 13195 are 5, 7, 13 and 29.
//   What is the largest prime factor of the number 600851475143 ?

using System;
using System.Collections;
using System.Numerics;
using System.Collections.Generic;

namespace Euler.Polyglot.CS
{
    public class Problem3
    {
        public List<long> FindPrimes(BigInteger n)
        {
            List<long> primes = new List<long>();
            if (n < 2) return primes;
            primes.Add(2);
            if (n % 2 == 0) return primes;
           
            bool isPrime = true;
            for (var i = 3; i < n; i += 2)
            {
                for (var j = 3; j <= Math.Sqrt(i); j++)
                    if (i % j == 0)
                        isPrime = false;
                if (isPrime)
                    primes.Add(i);
                else
                    isPrime = true;
            }

            return primes;
        } 

        public List<long> FindFactors (List<long> nums, BigInteger m)
        {
            List<long> factors = new List<long>();
            foreach (int num in nums)
            {
                if (m % num == 0)
                    factors.Add(num);
            }
            return factors;

        }
    }
}