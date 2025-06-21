using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter3
{
    public struct Point
    {
        public int x;
        public int y;
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public void Display()
        {
            Console.WriteLine("Value of X : " + x);
            Console.WriteLine("value of Y: " + y);
        }
    }
    internal class @struct
    {
        static void Main(String[] args)
        {
            Point p = new Point(10, 20);
            p.Display();
        }

    }
}
