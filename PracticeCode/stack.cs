using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter3
{
    internal class stack
    {
        static void Main()
        {
            Stack<int> stack = new Stack<int>();

            //push an elements in stack
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            foreach(int i in stack)
            {
                Console.WriteLine(i);
            }
            //pop in element in stack
            stack.Pop();
            foreach(int i in stack)
            {
                Console.WriteLine(i);
            }
            //preview as the most recent element on the stack
            stack.Peek();
            foreach(int i in stack)
            {
                Console.WriteLine(i);
            }

        }
    }
}
