using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter3
{
    class Complex1
    {
        private int x;
        private int y;
        //default constructor
        public Complex1()
        {
            this.x = 0;
            this.y = 0;
        }
        //parameterized constructor
        public Complex1(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void ShowXY()
        {
            Console.WriteLine("{0} {1}", x, y);
            Console.ReadLine();
        }

        public static Complex1 operator +(Complex1 c1, Complex1 c2)
        {
            Complex1 temp = new Complex1();
            temp.x = c1.x + c2.x;
            temp.y = c1.y + c2.y;
            return temp;


        }

        
    }
    internal class Overloading_Binary_Operator
    {
        static void Main(String[] args)
        {
            Complex1 c1 = new Complex1(10, 20);
            c1.ShowXY();

            Complex1 c2 = new Complex1(20, 30);
            c2.ShowXY();

            Complex1 c3 = new Complex1();
            c3 = c1 + c2;
            c3.ShowXY();
        }
    }
}
