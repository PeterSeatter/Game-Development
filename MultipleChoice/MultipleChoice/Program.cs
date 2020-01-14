using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleChoice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Welcome to the Simple Questions***");

            Console.WriteLine("Please enter your first name:");
            var firstName = Console.ReadLine();

            Console.WriteLine("Please enter your last name:");
            var lastName = Console.ReadLine();

            Console.WriteLine("Please enter your Date of Birth:");
            var dob = Console.ReadLine();

            Console.WriteLine("What month were you born?");
            var month = Console.ReadLine();

            //Console.WriteLine("Hi, {0} {1} Born: {2} Month: {3}", firstName, lastName,  dob, month);
            Console.WriteLine("Hi, " + firstName + " " + lastName + " Born: " + dob + " Month: " + month);
            
            if(month == "march")
            {
                Console.WriteLine("You are an Aries");
            }

            else if (month.ToLower() == "april" || month.ToLower() == "may")
            {
                Console.WriteLine("You are a Taurus");
            }

            else if (month == "may")
            {
                Console.WriteLine("You are a Gemini");
            }
            Console.ReadKey();
            
        }
    }
}

