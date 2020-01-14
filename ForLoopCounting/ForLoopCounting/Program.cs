using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoopCounting
{
    class Program
    {
        static int passTimes = 0;

        static void Main(string[] args)
        {
            CountingMethod();
        }

        static void CountingMethod()
        {
            while(passTimes != 5)
	        {
                for(int i =1; i <= 10; i++)
                {
                    Console.WriteLine(i);
                }

                for(int h = 10; h >= 1; h--)
                {
                    Console.WriteLine(h);
                }
                passTimes++;
	        }            
        }
    }
}
