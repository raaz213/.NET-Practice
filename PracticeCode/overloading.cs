using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace chapter3
{
    public class Addition
    {
        public int sum(int a, int b)
        {
             return  a + b;
        }
        public int sum(int a, int b, int c)
        {
            return a + b + c;
        }
        public double sum(double a, double b)
        {
            return a + b;
        }
    }
    internal class overloading
    {
        static void Main(String[] args)
        {
            Addition a = new Addition();
            int sum1 = a.sum(10, 20);
            int sum2 = a.sum(10, 20, 30);
            double sum3 = a.sum(10.5, 20.5);
            Console.WriteLine(sum1);
            Console.WriteLine(sum2);
            Console.WriteLine(sum3);
        }
    }
}
