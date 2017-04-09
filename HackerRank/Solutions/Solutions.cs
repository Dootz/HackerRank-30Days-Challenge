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

        public static void Day3(int number)
        {
            string answer = "";
            bool flag0, flag1, flag2, flag3 = flag2 = flag1 = flag0 = false;
            if (number % 2 == 1)
                answer = "Weird";
            else
            {
                if (number >= 2 && number <= 5)
                    flag1 = true;
                else if (number >= 6 && number <= 20)
                    flag2 = true;
                else if (number > 20)
                    flag3 = true;
            }
            if (flag1 || flag3)
                answer = "Not Weird";
            if (flag2 || flag0)
                answer = "Weird";

            Console.WriteLine(answer);
        }
    }
}
