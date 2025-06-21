using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter3
{
    public class readOnly
    {
        //This method tries to modify the readonly field, which will result in a compilation error.
        // Uncommenting the following lines will result in a compilation error.
        // Readonly field can only be assigned a value during declaration or in the constructor.
        public readonly int readOnlyField;
        public readOnly(int x)
        {
            readOnlyField = x;
        }
        public void display()
        {
            Console.WriteLine(readOnlyField);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            readOnly r = new readOnly(10);
            r.display();
        }
    }
}
