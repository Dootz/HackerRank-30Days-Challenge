using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

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
        public static void Day14()
        {
            Convert.ToInt32(Console.ReadLine());

            int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

            Difference d = new Difference(a);

            d.computeDifference();

            Console.Write(d.maximumDifference);
        }  
        public static void Day15()
        {
            Node head = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                head = insert(head, data);
            }
            display(head);
        }
        public static void Day16()
        {
            string S = Console.ReadLine();
            try
            {
                int value = Convert.ToInt32(S);
                Console.WriteLine(value);
            }
            catch(Exception e)
            {
                Console.WriteLine("Bad String");
            }
        }
        public static  void Day17()
        {
            Calculator myCalculator = new Calculator();
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                string[] num = Console.ReadLine().Split();
                int n = int.Parse(num[0]);
                int p = int.Parse(num[1]);
                try
                {
                    int ans = myCalculator.power(n, p);
                    Console.WriteLine(ans);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);

                }
            }
        }
        public static void Day18()
        {
            string s = Console.ReadLine();

            // create the Solution class object p.
            Day18 obj = new Day18();

            // push/enqueue all the characters of string s to stack.
            foreach (char c in s)
            {
                obj.pushCharacter(c);
                obj.enqueueCharacter(c);
            }

            bool isPalindrome = true;

            // pop the top character from stack.
            // dequeue the first character from queue.
            // compare both the characters.
            for (int i = 0; i < s.Length / 2; i++)
            {
                if (obj.popCharacter() != obj.dequeueCharacter())
                {
                    isPalindrome = false;

                    break;
                }
            }

            // finally print whether string s is palindrome or not.
            if (isPalindrome)
            {
                Console.Write("The word, {0}, is a palindrome.", s);
            }
            else
            {
                Console.Write("The word, {0}, is not a palindrome.", s);
            }
        }
        public static void Day19()
        {
            int n = Int32.Parse(Console.ReadLine());
            AdvancedArithmetic myCalculator = new Calculator_Day19();
            int sum = myCalculator.divisorSum(n);
            Console.WriteLine("I implemented: AdvancedArithmetic\n" + sum);
        }
        public static void Day20()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);
            // Write Your Code Here
            int numberOfSwaps = 0;
            int temp = 0;
            int tempSwapCounter = 1;
            while(tempSwapCounter != 0)
            {
                tempSwapCounter = 0;
                for (int i = 0; i <= n - 2; i++)
                {
                    if (a[i] > a[i + 1])
                    {
                        numberOfSwaps++;
                        temp = a[i];
                        a[i] = a[i + 1];
                        a[i + 1] = temp;
                        tempSwapCounter++;
                    }
                }

            }
            Console.WriteLine("Array is sorted in " + numberOfSwaps + " swaps.");
            Console.WriteLine("First Element: " + a[0]);
            Console.WriteLine("Last Element: " + a[n - 1]);
        }

        public static void Day21()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] intArray = new int[n];
            for (int i = 0; i < n; i++)
            {
                intArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            n = Convert.ToInt32(Console.ReadLine());
            string[] stringArray = new string[n];
            for (int i = 0; i < n; i++)
            {
                stringArray[i] = Console.ReadLine();
            }

            Printer.PrintArray<Int32>(intArray);
            Printer.PrintArray<String>(stringArray);
        }

        public static void Day22()
        {
            Node_Day22 root = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                root = insert(root, data);
            }
            int height = getHeight(root);
            Console.WriteLine(height);
        }

        public static int getHeight(Node_Day22 root)
        {
            int count = 0;
            if (root == null)
                return 0;
            int left = getHeight(root.left);
            int right = getHeight(root.right);

            if (left > right)
                count = left + 1;
            else
                count = right + 1;

            return count;
        }

        public static void display(Node head)
        {
            Node start = head;
            while (start != null)
            {
                Console.Write(start.data + " ");
                start = start.next;
            }
        }
        public static Node_Day22 insert(Node_Day22 root, int data)
        {
            if (root == null)
            {
                return new Node_Day22(data);
            }
            else
            {
                Node_Day22 cur;
                if (data <= root.data)
                {
                    cur = insert(root.left, data);
                    root.left = cur;
                }
                else
                {
                    cur = insert(root.right, data);
                    root.right = cur;
                }
                return root;
            }
        }

        public static Node insert(Node head, int data)
        {
            if (head == null)
            {
                return new Node(data);
            }
            else
            {
                Node tempNode = head;
                while(tempNode.next != null)
                {
                    tempNode = tempNode.next;
                }
                Node tempNode2 = new Node(data);
                tempNode.next = tempNode2;
                return head;
            }
        }

    }
}
