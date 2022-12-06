using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    internal static class Factorial
    {
        internal static int Factorial1(int x)
        {
            if (x < 0) throw new ArgumentOutOfRangeException();
            if (x == 0 || x == 1) return 1;
            return x * Factorial1(x - 1);
        }

        internal static int Factorial2(int x)
        {
            if (x < 0) throw new ArgumentOutOfRangeException();
            if (x == 0 || x == 1) return 1;

            int retval = x;
            while (x > 2)
            {
                retval = retval * (--x);
            }

            return retval;
        }

       
        internal static  int Factorial3(int x)
        {
            return FactTail(x, 1);
        }

        private static int FactTail(int x, int acc)
        {
            return (x == 0) ? acc : FactTail(x - 1, acc * x);
        }
    }
}
