//Problem 1
//=========
//   If we list all the natural numbers below 10 that are multiples of 3 or 5,
//   we get 3, 5, 6 and 9. The sum of these multiples is 23.

//   Find the sum of all the multiples of 3 or 5 below 1000.

using System;
using System.Collections;

namespace Euler.Polyglot.CS
{
    public class Problem1
    {
        public ArrayList FindMultiples(int n, int[] mult)
        {
            ArrayList Multiples = new ArrayList(); 
            int cnt=0;
            for (int i=2; i<n; i++)
            {
                foreach (int m in mult)
                    if (i % m == 0)
                        Multiples.Add(i);
            }
            return Multiples;
        }

        public int SumArray (ArrayList arr)
        {
            int sum = 0;
            foreach (int e in arr)
            {
                sum+= e;
            }
            return sum;
        }
     
    }
}