using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Solutions
{
    class Day18
    {
        private Stack<char> myStack;
        private Queue<char> myQueue;
        
        public Day18()
        {
            myStack = new Stack<char>();
            myQueue = new Queue<char>();
        }
        public void pushCharacter(char s)
        {
            myStack.Push(s);
        }

        public char popCharacter()
        {
            return myStack.Pop();
        }

        public void enqueueCharacter(char s)
        {
            myQueue.Enqueue(s);
        }
        
        public char dequeueCharacter()
        {
            return myQueue.Dequeue();
        }
    }
}
