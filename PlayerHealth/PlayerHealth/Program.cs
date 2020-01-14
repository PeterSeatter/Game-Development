using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerHealth
{
    class Program
    {
        static void Main(string[] args)
        {
            Player();
        }

        //the player method which hold all the information and calculations required for asking the user for input and displaying the player's health
        static void Player()
        {
            int health = 10;

            //while loop that holds the information that will alter the health integer
            while (health >= 0)
            {
                Console.WriteLine("Current player health is " + health + "....");
                //This states that if the health is greater than zero than it will do the if otherwise it will execute the else statement and tell the player they are dead and stops the program.
                if (health > 0)
                {
                    Console.WriteLine("Enter a number to deduct player health");
                    int playerInput = Int32.Parse(Console.ReadLine());
                    health = health - playerInput;
                }
                else
                {
                    Console.WriteLine("***Game Over*** Player is Dead!");
                    break;
                }
            }
        }
    }
}
