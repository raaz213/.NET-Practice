using System;

namespace chapter3
{
    class Shape
    {
        protected string name;
        protected double area;

        public Shape(string name)
        {
            this.name = name;
        }

        public void Display()
        {
            Console.WriteLine("Calculating the area of " + name);
        }
    }

    class Circle : Shape
    {
        public double radius;

        public Circle(string name, double radius) : base(name)
        {
            this.radius = radius;
        }

        public void CalculateAreaCircle()
        {
            area = 3.14 * radius * radius;
            Console.WriteLine("Area: " + area);
        }
    }

    class Rectangle : Shape
    {
        public double length;
        public double height;

        public Rectangle(string name, double length, double height) : base(name)
        {
            this.length = length;
            this.height = height;
        }

        public void CalculateAreaRectangle()
        {
            area = length * height;
            Console.WriteLine("Area: " + area);
        }
    }

    internal class HierarchicalInheritance
    {
        static void Main(string[] args)
        {
            Circle c = new Circle("circle", 50);
            c.Display();
            c.CalculateAreaCircle();

            Rectangle r = new Rectangle("rectangle", 50, 50);
            r.Display();
            r.CalculateAreaRectangle();
        }
    }
}
