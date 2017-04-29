using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Solutions
{
    class Node_Day22
    {
        public Node_Day22 left, right;
        public int data;
        public Node_Day22(int data)
        {
            this.data = data;
            left = right = null;
        }
    }
}
