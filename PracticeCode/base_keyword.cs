using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter3
{
    public class Animal
    {
        public string color = "white";
    }
    public class Dog : Animal
    {
        public string color = "black";
        public void ShowColor()
        {
            Console.WriteLine(base.color); //display white;
            Console.WriteLine(color); //display black;
        }
    }
    internal class base_keyword
    {
        static void Main(String[] args)
        {
            Dog d = new Dog();
            d.ShowColor();
        }
    }
}
