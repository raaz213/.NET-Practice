using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter3
{
    internal class Generics_method
    {
        static void Swap<T>(T a, T b)
        {
            T temp;
            temp = a;
            a = b;
            b = temp;
        }
        static void Main(String[] args)
        {
            int a = 10, b = 20;
            Console.WriteLine("Before Swap: {0}, {1} ", a, b);
            Swap<int>(a,  b);
            Console.WriteLine("After Swap: {0}, {1} ", a, b);
        }

    }
}
