using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadSafeSingleton
{
    public class ThreadSafeSingletonMain
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** SOLDIER MAINTENANCE ****");
            Console.WriteLine("Creating a soldier....");
 
            Soldier badlyInjuredSoldier = new Soldier(5);

            Soldier tiredSoldier = new Soldier(93);

            Console.WriteLine("The soldier's health is " + badlyInjuredSoldier.Health);
 
            Console.WriteLine("The soldier's health is " + tiredSoldier.Health);
 
            Console.WriteLine("Using the Medic singleton to give more health....");
 
            int existingHealth = badlyInjuredSoldier.Health;
            int existingHealth2 = tiredSoldier.Health;
            int additionalHealth = Medic.HealthSupply.GiveHealth(existingHealth);
            int additionalHealth2 = Medic.HealthSupply.GiveHealth(existingHealth2);
 
            badlyInjuredSoldier.Health = existingHealth + additionalHealth;
            tiredSoldier.Health = existingHealth2 + additionalHealth2;
 
            Console.WriteLine("The soldier's health is now " + badlyInjuredSoldier.Health);
            Console.WriteLine("The soldier's health is now " + tiredSoldier.Health);

            Console.ReadKey();
        }
    }
}
