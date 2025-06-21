using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter3
{
    interface A2
    {
        int CalculateArea();
        int CalculatePerimeter();

    }
    class B2 
    {
        public int length, breadth;
        public void ReadData(int length, int breadth)
        {
            this.length = length;
            this.breadth = breadth;
        }

    }
    class C2 :B2,A2
    {

        public int CalculateArea()
        {


            ReadData(10, 20);
            int area = length * breadth;
            return area;
        }
        public int CalculatePerimeter()
        {
            ReadData(10, 15);
            int perimeter = 2 * (length * breadth);
            return perimeter;

        }
    }
    internal class multiple_inheritance
    {
        static void Main(String[] args)
        {
            C2 c = new C2();
           int perimeter =  c.CalculatePerimeter();
            Console.WriteLine(perimeter);
            int area = c.CalculateArea();
            Console.WriteLine(area);
        }
    }
}
