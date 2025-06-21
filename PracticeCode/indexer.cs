using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter3
{
    class indexClass
    {
        private string[] names = new string[3];
        public string this[int i]
        {
            get { return names[i]; }

            set { names[i] = value; }
        }
    }
    internal class indexer
    {
        static void Main(String[] args)
        {
            indexClass team = new indexClass();
            team[0] = "Rocky";
            team[1] = "Teena";
            team[2] = "Aha";
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine(team[i]);
            }
        }
    }
}
