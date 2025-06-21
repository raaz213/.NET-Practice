using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter3
{
    public class MyClass2
    {
        public int a { get; set; }
        public int b { get; set; }
        public int sum
        {
            get
            {
                return a + b;
            }
        }
    }
    internal class automatic_property
    {
        static void Main(String[] args)
        {
            MyClass2 myClass = new MyClass2();
            myClass.a = 10;
            myClass.b = 20;
            Console.WriteLine("Sum of " + myClass.a + "and" + myClass.b + "=" + myClass.sum);
            Console.ReadKey();
        }
    }
}
