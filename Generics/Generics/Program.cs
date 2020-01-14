using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        private class ExampleClass { }
        
        static void Main(string[] args)
        {
            //Declare a list of type int.
            List<int> list1 = new List<int>();

            //Declare a list of type string.
            List<string> list2 = new List<string>();

            //Declare a list of type ExampleClass.
            List<ExampleClass> list3 = new List<ExampleClass>();

            //TODO
            list2.Add("Generic John");
            Console.WriteLine(list2[0]);
        }
    }
}
