using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Solutions
{
    class Calculator_Day19 : AdvancedArithmetic
    {
        private int sum = 0;
        public int divisorSum(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                    sum += i;
            }
            return sum;
        }
    }
}
