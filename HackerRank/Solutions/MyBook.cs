using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Solutions
{
    class MyBook:Book
    {
        private int price;
        public MyBook(string t, string a, int c) : base(t, a)
        {
            this.title = t;
            this.author = a;
            price = c;
        }

        public override void display() 
        {
            StringBuilder output = new StringBuilder();
            output.Append($"Title: {this.title}");
            output.Append($"\nAuthor: {this.author}");
            output.Append($"\nPrice: {this.price}");
            Console.WriteLine(output);
        }
    }
}
