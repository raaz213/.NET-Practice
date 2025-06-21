using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter3
{
    public class Swap<T>
    {
        private T a;
        private T b;
        private T temp;
        public Swap(T a, T b)
        {
            this.a = a;
            this.b = a;
        }
        public void SwapMethod()
        {
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("Swapping : {0}, {1} ", a, b);
        }
    }
    internal class Generic_class
    {
        static void Main(String[] args)
        {
            Swap<int> sc = new Swap<int>(10, 20);
            sc.SwapMethod();

        }
    }
}
