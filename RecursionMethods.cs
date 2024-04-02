using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG211Lab10
{
    internal class RecursionMethods
    {
        public int SumBetween(int m, int n)
        {
            //Make sure m is smaller
            if (n < m)
            {
                return SumBetween(n, m);
            }

            if (m == n)
            {
                return m;
            }
            else
            {
                return n + SumBetween(m, n - 1);
            }
        }

        public int TimesDivisibleByTwo(int m, int divided = 0)
        {
            if (m % 2 == 1)
            {
                return divided;
            }
            else
            {
                return TimesDivisibleByTwo(m / 2, divided + 1);
            }
        }
    }
}
