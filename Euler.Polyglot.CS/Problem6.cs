﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Euler.Polyglot.CS
{

//Problem 6
//=========
//   The sum of the squares of the first ten natural numbers is,
//                          1^2 + 2^2 + ... + 10^2 = 385
//   The square of the sum of the first ten natural numbers is,
//                       (1 + 2 + ... + 10)^2 = 55^2 = 3025
//   Hence the difference between the sum of the squares of the first ten
//   natural numbers and the square of the sum is 3025 âˆ’ 385 = 2640.
//   Find the difference between the sum of the squares of the first one
//   hundred natural numbers and the square of the sum.
   
    public class Problem6
    {        
        public BigInteger SumOfRange(IEnumerable<int> range)
        {
            var sum = new BigInteger();
            foreach (int i in range)
            {
                sum += i;
            }
            return sum;
        }

        public BigInteger SumOfSquares(IEnumerable<int> range)
        {
            var sum = new BigInteger();
            foreach (int i in range)
            {
                sum += i*i;
            }
            return sum;
        }


        public BigInteger SquareOfSum (IEnumerable<int> range)
        {
            var sum = new BigInteger();
            sum = SumOfRange(range);
            sum *= sum;
            return sum;
        }
    }
}
