using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNetLearning.Algorithms
{
    class Palindrome
    {
        static bool IsPalindrome(int nr)
        {
            int copie = nr;
            int inv = 0;
            while (nr > 0)
            {
                inv = inv * 10 + nr % 10;
                nr /= 10;
            }
            return inv == copie;
        }
        
        internal static void PrintPalindromes()
        {
            //for (int nr = 1; nr <= 100_000; nr++)
            //    if (IsPalindrome(nr))
            //        Console.WriteLine(nr);
            Enumerable.Range(1, 100_000)
                      .Where(IsPalindrome)
                      .ToList()
                      .ForEach(Console.WriteLine);
        }
    }
}
