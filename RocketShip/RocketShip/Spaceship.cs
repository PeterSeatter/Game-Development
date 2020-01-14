using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocketShip
{
    class Spaceship
    {
        private int fuel = 20;
        private int armour = 100;
        private string colour = "blue";

        public int Fuel { get => fuel; set => fuel = value; }
        public int Armour { get => armour; set => armour = value; }
        public string Colour { get => colour; set => colour = value; }

        public Spaceship()
        {
        }

        public Spaceship(int fuel, int armour, string colour)
        {
            Fuel = fuel;
            Armour = armour;
            Colour = colour;
        }

        public Spaceship(string colour)
        {
            Colour = colour;
        }

        //private int fuel = 20;
        //private int armour = 100;
        //private string colour = "blue";
        
        //public int FuelAmount
        //{
        //    get { return fuel; }
        //    set { fuel = value; }
        //}
        

        //public int ArmourLevel
        //{
        //    get { return armour; }
        //    set { armour = value; }
        //}
        

        //public string ColourType
        //{
        //    get { return colour; }
        //    set { colour = value; }
        //}

       
    }   
}
