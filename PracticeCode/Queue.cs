using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter3
{
    internal class QueueExample
    {
        static void Main(String[] args)
        {
            Queue<string> queue = new Queue<string>();
            //adding an element from the last
            queue.Enqueue("MCA");
            queue.Enqueue("BCA");

            //remove an element from the fast
            queue.Dequeue();


        }
    }
}
