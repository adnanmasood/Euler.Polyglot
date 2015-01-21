using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler.Polyglot.CS
{
 
//    Problem 5
//    =========
//    2520 is the smallest number that can be divided by each of the numbers
//    from 1 to 10 without any remainder.
//    What is the smallest positive number that is evenly divisible by all of
//    the numbers from 1 to 20?

   
  
    public class Problem5
    {
        //2520
        public long FindLargestDivisor(int range)
        {    
            long evenDivisor = 2;
            bool isEvenlyDivisble = true;
            while (true)
            {
                for (int i=1; i<=range; i++)
                {
                    if (evenDivisor % i != 0)
                    {
                        isEvenlyDivisble = false;
                        break; 
                    }
                }
                    if (isEvenlyDivisble)
                    {
                        return evenDivisor;                        
                    }
                    evenDivisor +=2;
                    isEvenlyDivisble = true;
            }                        
            return 0;
        }

        public bool IsPalindrome (int num)
        {
            return (Reverse(num.ToString()) == num.ToString());
        }

        public string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

    }
}
