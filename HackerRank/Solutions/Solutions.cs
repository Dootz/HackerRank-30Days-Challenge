using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        public static void Day4()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
                Console.WriteLine(n + " x " + i + " = " + n * i);
        }
        public static void Day6()
        {
            int numberOfTestCases;
            string inputString;
            int i;       
            Int32.TryParse(Console.ReadLine(), out numberOfTestCases);
            for(int n=0; n <= numberOfTestCases -1; ++n)
            {
                string evenString = "";
                string oddString = "";
                inputString = Console.ReadLine();
                for (i = 0; i<= inputString.Length-1; ++i)
                {
                    if (i % 2 == 1)
                        evenString += inputString[i];
                    else
                        oddString += inputString[i];
                }
                Console.WriteLine(oddString + " " + evenString);
            }
        }
        public static void Day7()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            for (int i = n; i >= 0; i--)
            {
                Console.Write(arr[i - 1] + " ");
            }
        }
        public static void Day8()
        {
            Dictionary<string, int> phoneBook = new Dictionary<string, int>();
            int n = Convert.ToInt32(Console.ReadLine());
            string input;
            for (int i = 0; i <= n - 1; i++)
            {
                input = Console.ReadLine();
                Regex regex = new Regex(@"\s");
                string[] bits = regex.Split(input.ToLower());
                phoneBook.Add( bits[0], Convert.ToInt32(bits[1]));
            }
            while(true)
            {
                string nameToFind = Console.ReadLine();
                if (nameToFind.ToLower().Equals("Exit"))
                    break;

                var result = phoneBook.ContainsKey(nameToFind);
                if(result)
                {
                    Console.WriteLine(nameToFind + "=" +phoneBook[nameToFind]);
                }
                else
                {
                    Console.WriteLine("Not found");
                }
            }
        }
        public static void Day9()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(factorial(n));

        }
        static int factorial(int number)
        {
            if (number <= 1)
                return 1;
            return number * factorial(number - 1);
        }    
    }
}
