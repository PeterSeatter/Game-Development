using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocketShip
{
    class Program
    {
        static void Main(string[] args)
        {
            RocketCreation();
        }

        static void RocketCreation()
        {
            Spaceship spaceship1 = new Spaceship();

            String className = nameof(spaceship1);
            Console.WriteLine(className + " has " + spaceship1.Fuel + " fuel.");
            Console.WriteLine(className + " has " + spaceship1.Armour + " armour.");
            Console.WriteLine(className + " is " + spaceship1.Colour + " in colour.");
            Console.WriteLine();

            Spaceship redShip = new Spaceship(10, 3, "red");

            className = nameof(redShip);
            Console.WriteLine(className + " has " + redShip.Fuel + " fuel.");
            Console.WriteLine(className + " has " + redShip.Armour + " armour.");
            Console.WriteLine(className + " is " + redShip.Colour + " in colour.");
            Console.WriteLine();

            Spaceship colourOnlyShip = new Spaceship("purple");
            className = nameof(colourOnlyShip);
            Console.WriteLine(className + " has " + colourOnlyShip.Fuel + " fuel.");
            Console.WriteLine(className + " has " + colourOnlyShip.Armour + " armour.");
            Console.WriteLine(className + " is " + colourOnlyShip.Colour + " in colour.");

            List<Spaceship> listOfShips = new List<Spaceship>();
            listOfShips.Add(spaceship1);
            listOfShips.Add(redShip);

            Console.WriteLine();
            Console.WriteLine(listOfShips[0].Colour);
            Console.WriteLine(listOfShips[1].Colour + " " + listOfShips[1].Armour + " " + listOfShips[1].Fuel);
            Console.WriteLine(listOfShips[0]);
            Console.WriteLine(spaceship1);

            Console.ReadLine();
            //List<Spaceship> Rocket = new List<Spaceship>();

            //bool creation = true;            

            //while (creation)
            //{
            //    Spaceship newRocket = new Spaceship();

                //Console.Write("Amount of fuel: ");
                //newRocket.FuelAmount = int.Parse(Console.ReadLine());

                //Console.Write("Amount of armour: ");
                //newRocket.ArmourLevel = int.Parse(Console.ReadLine());

                //Console.Write("Colour of the Spaceship: ");
                //newRocket.RocketColour = Console.ReadLine();

                //Rocket.Add(newRocket);

                //Console.WriteLine("Build another rocket? y/n");

                //if (Console.ReadLine() != "y")
                //    creation = false;

                //foreach (Spaceship  shipCreated in Rocket)
                //{
                //    Console.WriteLine("Fuel: {0}, Armour {1}, Colour {2}", shipCreated.FuelAmount, shipCreated.ArmourLevel, shipCreated.RocketColour);
                //}
            }
        }
    
}
