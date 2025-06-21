using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter3
{
    internal class Dictionary
    {
        static void Main(String[] args)
        {
            Dictionary<int, string> dic = new Dictionary<int, string>(2);
            dic.Add(1, "ram");
            dic.Add(2, "ravi");

            foreach(var item in dic)
            {
                Console.WriteLine(item);
            }
        }
    }
}
