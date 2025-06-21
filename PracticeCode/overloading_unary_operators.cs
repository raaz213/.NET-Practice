using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter3
{
    class Complex
    {
        private int x;
        private int y;
        
       //default constructor
        public Complex()
        {
            this.x = 0;
            this.y = 0;
        }

        //parameterized constructor
        public Complex(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        //copy constructor
        public Complex(Complex c)
        {
            this.x = c.x;
            this.y = c.y;
        }
        public void ShowXY()
        {
            Console.WriteLine("{0} {1}", x, y);
        }
        //overding unary operator
        public static Complex operator - (Complex c)
        {
            Complex temp = new Complex(c);
            temp.x = -c.x;
            temp.y = -c.y;
            return temp;
        }
    }
    internal class overloading_unary_operators
    {
        public static void Main(String[] args)
        {
            Complex c1 = new Complex(10, 20);
            c1.ShowXY();
            Complex c2 = new Complex();
            c2.ShowXY();
            c2 = -c1;
            c2.ShowXY();
        }
    }
}
