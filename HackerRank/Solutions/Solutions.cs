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
        public static void Day10()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int maxSum = 0;
            string binary = Convert.ToString(n, 2);
            Console.WriteLine(Convert.ToString(binary));
            for (int i = 0; i < binary.Length - 1; i++)
            {                
                char s = binary[i];
                
               if(i == 0)
                {
                    if (s == 49)
                    {
                        sum++;
                        if(sum > maxSum)
                        maxSum = sum;
                    }
                }
                else
                {
                    char c = binary[i - 1];
                    if(s == 49 && maxSum == 0)
                    {
                        sum++;
                        maxSum = sum;
                    }
                    else if(s == 49 && c == 49)
                    {
                        sum++;
                        if (sum > maxSum)
                            maxSum = sum;
                    }
                    else
                    {
                        sum = 0;
                    }
                }
            }
            Console.WriteLine(Convert.ToString(maxSum));
            Console.ReadLine();
        }
        public static void Day11()
        {
            int[][] arr = new int[6][];
            int maxSum = -50;
            int sum = 0;
            for (int arr_i = 0; arr_i < 6; arr_i++)
            {
                string[] arr_temp = Console.ReadLine().Split(' ');
                arr[arr_i] = Array.ConvertAll(arr_temp, Int32.Parse);
            }
            for (int k = 1; k <= 4; k++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    sum = arr[k][j] + arr[k - 1][j - 1] + arr[k - 1][j] + arr[k - 1][j + 1] + arr[k + 1][j - 1] + arr[k + 1][j] + arr[k + 1][j + 1];
                    if (sum > maxSum)
                        maxSum = sum;
                    sum = 0;
                }
            }
            Console.WriteLine(maxSum);
        } 
        public static void Day12()
        {
            string[] inputs = Console.ReadLine().Split();
            string firstName = inputs[0];
            string lastName = inputs[1];
            int id = Convert.ToInt32(inputs[2]);
            int numScores = Convert.ToInt32(Console.ReadLine());
            inputs = Console.ReadLine().Split();
            int[] scores = new int[numScores];
            for (int i = 0; i < numScores; i++)
            {
                scores[i] = Convert.ToInt32(inputs[i]);
            }

            Student s = new Student(firstName, lastName, id, scores);
            s.printPerson();
            Console.WriteLine("Grade: " + s.Calculate() + "\n");
            Console.ReadLine();
        } 
        public static void Day13()
        {
            String title = Console.ReadLine();
            String author = Console.ReadLine();
            int price = Int32.Parse(Console.ReadLine());
            Book new_novel = new MyBook(title, author, price);
            new_novel.display();
    }
}
