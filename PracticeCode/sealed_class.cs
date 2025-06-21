using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter3
{
    sealed class Base
    {
        public void display()
        {
            Console.WriteLine("This is a sealed class");

        }
    }

    internal class sealed_class
    {
        static void Main(String[] args)
        {
            Base b = new Base();
            b.display();
        }
    }
}
