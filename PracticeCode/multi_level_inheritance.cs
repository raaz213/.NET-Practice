using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter3
{
    class A1 {
        public int x, y, z;
        public void ReadData(int x, int y)
        {
            this.x = x;
            this.y = y;
            
        }
        public void Display()
        {
            Console.WriteLine("Value of X : " + x);
            Console.WriteLine("Value of Y : " + y);

        }
    }
    class B1 : A1
    { 
        public void Add()
        {
            base.z = base.x + base.y;
            Console.WriteLine("Sum= " + base.z);
        }

    }
    class C1 : B1
    {
        public void Sub()
        {
            base.z = base.x - base.y;
            Console.WriteLine("Difference = " + base.z);
        }

    }
    internal class multi_level_inheritance
    {
        static void Main(String[] args)
        {
            C1 c = new C1();
            c.ReadData(10, 20);
            c.Display();
            c.Add();
            c.Sub();
        }
    }
}
