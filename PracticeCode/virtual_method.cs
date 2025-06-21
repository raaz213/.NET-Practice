using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace chapter3
{
    public class shape02
    {
        public string name;
        public int area;
        public shape02(string name)
        {
            this.name = name;
        }
        public virtual void calculate()
        {
            Console.WriteLine("Calculating the area of " + name);
        }

    }
    public class circle: shape02
    {
        public int radius;
        public circle(string name, int radius) : base(name)
        {
            this.radius = radius;
        }
        public override void calculate()
        {
            base.calculate();
            area = (int)(3.14 * radius * radius);
            Console.WriteLine($"Area of {name} : {area}");
        }

    }
    internal class virtual_method
    {
        static void Main(String[] args)
        {
            circle c = new circle("circle", 50);
            c.calculate();
        }
    }
}
