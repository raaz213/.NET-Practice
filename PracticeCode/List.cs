using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter3
{
    internal class List
    {
        static void Main(String[] args)
        {
            List<int> list = new List<int>();
            list.Add(32);
            list.Add(21);
            list.Add(45);
            list.Add(45);

            list.Remove(21);

            List<string> list2 = new List<string>();
            list2.Add("Mahesh Chand");
            list2.Add("Chris Love");
            list2.Add("Allen O' neill");

            foreach(string i in list2)
            {
                Console.WriteLine(i);
            }

        }
    }
}
