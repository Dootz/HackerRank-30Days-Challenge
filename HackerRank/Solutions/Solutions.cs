using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Solutions
{
    static class Solutions
    {
        public static void Day1(string s, int i, double d)
        {
            int ii;
            double dd;
            string ss;

            Double.TryParse(Console.ReadLine(), out dd);
            Int32.TryParse(Console.ReadLine(), out ii);
            
            ss = Console.ReadLine();

            Console.WriteLine(i + ii);
            Console.WriteLine(string.Format("{0:0.0}", d + dd));
            Console.WriteLine(s + ss);
        }

        public static void Day2(double mealCost, int tipPercent, int taxPercent)
        {
            Double.TryParse(Console.ReadLine(), out mealCost);
            Int32.TryParse(Console.ReadLine(), out tipPercent);
            Int32.TryParse(Console.ReadLine(), out taxPercent);

            int totalCost = (int)(mealCost * tipPercent / 100 + mealCost * taxPercent / 100 + mealCost);
            Console.WriteLine("The total meal cost is " + totalCost + " dollars.");
        }
    }
}
