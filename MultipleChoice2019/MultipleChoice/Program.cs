using System;

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
            
            Console.WriteLine("Hi, {0} {1} {2} {3} {4} {5}", firstName, lastName, "Born:", dob, "Month:", month);
            Console.ReadKey();
        }
    }
}
