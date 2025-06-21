using System;
using System.Collections;

namespace chapter3
{
    internal class ArrayListExample
    {
        static void Main(string[] args)
        {
            ArrayList personList = new ArrayList();

            // Add
            personList.Add("raj");
            personList.Add("ravi");
            personList.Add("Eshu");

            // Remove
            personList.Remove("Eshu");

            // Remove at specific index
            // Note: Index is 2 since ArrayList is 0-indexed
            personList.RemoveAt(2);

            // Clear all items
            personList.Clear();

           

            // Other methods
            personList.Insert(1, "shaijal");

            // Get the count
            int count = personList.Count;

            // Print count to console
            Console.WriteLine("Count: " + count);
        }
    }
}
