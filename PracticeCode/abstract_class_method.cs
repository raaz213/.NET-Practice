using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter3
{
    public abstract class Shape0
    {
        public abstract void draw();
    }
    public class Rectangle0 : Shape0
    {
        public override void draw()
        {
            Console.WriteLine("Drawing rectangle");
        } 
    }
    internal class abstract_class_method
    {
        static void Main(String[] args)
        {
            Rectangle0 r = new Rectangle0();
            r.draw();
        }
    }
}
