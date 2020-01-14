using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FopLoopGuessing
{
    class Program
    {
        static void Main(string[] args)
        {
            Guessing();
        }

        static void Guessing()
        {
            int[] numbers = new int[] {10, 12, 6, 1};
            Console.WriteLine("What is your guess for the number stored in the array?");
            int guess = Int32.Parse(Console.ReadLine()); 
            for (int i = 0; i <= 1; i++)
			{
                if(numbers.Contains(guess))
                {
                    Console.WriteLine("You've guessed correctly");
                }
                else
                {
                    Console.WriteLine("You didn't guess correctly");
                }
                i++;
			}
        }
    }
}
