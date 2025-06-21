using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter3
{
    public class consDes
    {
        public consDes(string message)
        {
            Console.WriteLine(message);
        }
        ~consDes()
        {
            Console.WriteLine("This is a destructor");
            Console.ReadKey();
        }
        public void display()
        {
            Console.WriteLine("This is method");
        }
        
    }
    internal class destructor
    {
        static void Main(String[] args)
        {
            consDes con = new consDes("Hello world");
            con.display();

        }

    }
}
