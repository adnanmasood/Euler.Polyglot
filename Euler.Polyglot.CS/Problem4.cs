using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler.Polyglot.CS
{
    //   A palindromic number reads the same both ways. The largest palindrome made
    //  from the product of two 2-digit numbers is 9009 = 91 Ã— 99.
    //  Find the largest palindrome made from the product of two 3-digit numbers.   
   
    public class Problem4
    {
        //111 - 999
        public int FindLargestPalindrome()
        {
            List <int> list = new List<int>();
            for (int i=999; i>=100; i--)
                for (int j=999; j>=100; j--)
                {
                    var num = i*j;
                    if (IsPalindrome(num))
                        list.Add(num);
                }

            list.Sort();

            return list[list.Count - 1];
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
