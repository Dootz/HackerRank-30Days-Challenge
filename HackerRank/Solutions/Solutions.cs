using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Solutions
{
    class Solutions
    {
        public void Day1()
        {
            int i = 4;
            double d = 4.0;
            string s = "HackerRank";

            int ii;
            double dd;
            string ss;

            Int32.TryParse(Console.ReadLine(), out ii);
            Double.TryParse(Console.ReadLine(), out dd);
            ss = Console.ReadLine();

            Console.WriteLine(i + ii);
            Console.WriteLine(string.Format("{0:0.0}", d + dd));
            Console.WriteLine(s + ss);
        }
    }
}
