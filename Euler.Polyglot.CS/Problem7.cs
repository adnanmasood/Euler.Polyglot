using System;
using System.Collections.Generic;

namespace Euler.Polyglot.CS
{
    //Problem 7
    //=========

    //   By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see
    //that the 6th prime is 13.
    // What is the 10 001st prime number?

    public class Problem7
    {
        public long GetNthPrime(int nth)
        {
            var primes = new List<long>();
            primes.Add(2);
            bool isPrime = true;
            int i = 3;
            int cnt = 1;

            while (cnt < nth)
            {
                for (int j = 3; j <= Math.Sqrt(i); j++)
                    if (i%j == 0)
                        isPrime = false;
                if (isPrime)
                {
                    primes.Add(i);
                    cnt++;
                }
                else
                    isPrime = true;

                i += 2;
            }

            return primes[primes.Count-1];
        }
    }
}