using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter3
{   static class person
    {
        public static int id;
        public static string name;
        public static void display()
        {
            Console.WriteLine("Id = {0} \t Name = {1}", id, name);
        }
    }
    internal class static_class
    {
        static void Main(String[] args)
        {
            person.id = 001;
            person.name = "Ram";
            person.display();
        }
    }
}
