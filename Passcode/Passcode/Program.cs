using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passcode
{
    class Program
    {
        static void Main(string[] args)
        {
            PasscodeMethod();
        }

        static void PasscodeMethod()
        {
            bool athorPasscode = false;
            int i = 0;

            Console.WriteLine("Please enter the passcode");       

            while (athorPasscode == false && i != 3)
            {
                string passCode = Console.ReadLine();
                i++;
                if (passCode == "secret")
                {
                    Console.WriteLine("You've been Authenicated!, it took " + i + " attempt/s.");
                    athorPasscode = true;
                }
                else
                {
                    Console.WriteLine("Sorry, that code in invalid, you've had " + i + " attempts");
                    
                    if (i == 3)
                    {
                        Console.WriteLine("You've run out of attempts please try again later");
                    }
                }              
            }
        }
    }
}
