using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericListsBasics
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static void Collectibles()
        {
            List<T> collectibles = new List<T>();

            collectibles.Add(new T { item = "star", value = 2 });

        }
    }

    class T
    {
        public string item { get; set; }
        public int value { get; set; }
    }
}
