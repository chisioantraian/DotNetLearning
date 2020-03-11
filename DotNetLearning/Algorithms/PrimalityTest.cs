using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetLearning.Algorithms
{
    class PrimalityTest
    {
        static bool IsPrime(int nr)
        {
            if (nr < 2)
                return false;
            if (nr == 2 || nr == 3)
                return true;
            if ((nr % 2 == 0) || (nr % 3 == 0))
                return false;
            for (int div = 5; div * div < nr; div += 6)
                if ((nr % div == 0) || (nr % (div + 2) == 0))
                    return false;
            return true;
        }

        internal static void PrintPrimes()
        {
            for (int nr = 1; nr <= 1000; nr++)
                if (IsPrime(nr))
                    Console.WriteLine(nr);
        }
    }
}
