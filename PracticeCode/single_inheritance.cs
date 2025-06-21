using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter3
{
    public class A
    {
        public int x = 10, y = 20;
        public void displayA()
        {
            Console.WriteLine("This is a class A");
        }

    }
    public class B : A
    {
        public void displayValue()
        {
            Console.WriteLine("Value of X : " + x);
            Console.WriteLine("Value of X : " + y);

        }
        public void displayB()
        {
            Console.WriteLine("This is a class B");
        }
        

    }
    internal class single_inheritance
    {
        static void Main(String[] args)
        {
            B b = new B();
            b.displayA();
            b.displayB();
            b.displayValue();

        }
    }
}
