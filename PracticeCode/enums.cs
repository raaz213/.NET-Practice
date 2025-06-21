using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter3
{
    enum month
    {
        jan,
        feb,
        mar, 
        apr,
        may
    }
    internal class enums
    {
        static void Main(String[] args)
        {
            Console.WriteLine("The value of Jan in Month enum is " + (int)month.jan);
            Console.WriteLine("The value of Feb in Month enum is " + (int)month.feb);
            Console.WriteLine("The value of Mar in Month enum is " + (int)month.mar);
            Console.WriteLine("The value of Jan in Month enum is " + (int)month.apr);
            Console.WriteLine("The value of Feb in Month enum is " + (int)month.may);
          
        }
    }
}
