using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Solutions
{
    class Printer
    {
        public static void PrintArray<T>(T[] inputArray)
        {
            foreach(T element in inputArray)
            {
                Console.WriteLine(element.ToString());
            }
        }
    }
}
