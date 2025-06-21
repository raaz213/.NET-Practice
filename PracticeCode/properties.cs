using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter3
{
    class MyClass
    {
        private int x;
        public void setX(int n)
        {
            x = n;
        }
        public int getX()
        {
            return x;
        }
    }
    internal class properties
    {
        static void Main(String[] args)
        {
            MyClass obj1 = new MyClass();
            obj1.setX(10);
            int xVal = obj1.getX();
            Console.WriteLine(xVal);
        }
    }
}
