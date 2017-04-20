using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Solutions
{
    class Difference
    {
        private int[] elements;
        public int maximumDifference;
        public Difference(int[] array)
        {
            this.elements = array;
        }
        public int computeDifference()
        {
            int tempDiff;
            maximumDifference = 0;            
            
            for (int i = 0; i <= elements.Length-2; i++)
            {
                for (int j = 1; j <= elements.Length-1; j++)
                {
                    tempDiff = Math.Abs(elements[i] - elements[j]);
                    if (tempDiff > maximumDifference)
                        maximumDifference = tempDiff;
                }
            }
            return maximumDifference;
        }
    }
}
