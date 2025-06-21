using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter3
{
   
    internal class boxing_and_unboxing
    {
        static void Main(String[] args)
        {
            //boxing
            int x = 10;
            object obj = x;
            Console.WriteLine(obj.ToString());

            //unboxing
            object obj2 = 20;
            int x2 = (int)obj2;
            Console.WriteLine(x2.ToString());
        }
    }
}
