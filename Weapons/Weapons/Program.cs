using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weapons
{
    enum WeaponType
    {
        Gun,
        Blade,
        Magic
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating some weapons and adding them to a list. The weapons are: ");
            OutputText();

        }

        static void OutputText()
        {
            List<Weapon> listOfWeapons = new List<Weapon>();

            Weapon weapon1 = new Weapon("Phase Pistol", WeaponType.Gun, 50);
            listOfWeapons.Add(weapon1);

            Weapon weapon2 = new Weapon("Slow Down Spell", WeaponType.Magic, 25);
            listOfWeapons.Add(weapon2);

            Weapon weapon3 = new Weapon("Klingon Batleth", WeaponType.Blade, 35);
            listOfWeapons.Add(weapon3);

            foreach (Weapon lcWeapon in listOfWeapons)
            {
                ShowWeapon(lcWeapon);
            }
            
            UpgradeAllWeapons(listOfWeapons);         
        }

        public static void ShowWeapon(Weapon prWeapon)
        {
            Console.WriteLine("Name: " + prWeapon.ItemName + ", Type: " + prWeapon.WeaponType + ", Damage: " + prWeapon.DamageDealt);
        }

        static void UpgradeAllWeapons(List<Weapon> prToUpgrade)
        {
            foreach (Weapon lcWeapon in prToUpgrade)
            {
                switch (lcWeapon.WeaponType)
                {
                    case WeaponType.Gun:
                        lcWeapon.DamageDealt += 12;
                        break;
                    case WeaponType.Magic:
                        lcWeapon.DamageDealt += 5;
                        break;
                    case WeaponType.Blade:
                        lcWeapon.DamageDealt += 10;
                        break;
                }
                Console.WriteLine("Weapons Upgraded");
                ShowWeapon(lcWeapon);
            }
        }
    }
}
