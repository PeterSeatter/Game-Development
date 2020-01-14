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

            Weapon weapon2 = new Weapon("Slow Down Sleep", WeaponType.Magic, 25);
            listOfWeapons.Add(weapon2);

            Weapon weapon3 = new Weapon("Klingon Batleth", WeaponType.Blade, 35);
            listOfWeapons.Add(weapon3);

            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine("Name: " + listOfWeapons[0].ItemName + ", Type: " + listOfWeapons[0].WeaponType + ", Damage: " + listOfWeapons[0].DamageDealt);
                Console.WriteLine("Name: " + listOfWeapons[1].ItemName + ", Type: " + listOfWeapons[1].WeaponType + ", Damage: " + listOfWeapons[1].DamageDealt);
                Console.WriteLine("Name: " + listOfWeapons[2].ItemName + ", Type: " + listOfWeapons[2].WeaponType + ", Damage: " + listOfWeapons[2].DamageDealt);
                i++;
            }

            //UpgradeAllWeapons();
            UpgradeAllWeapons(listOfWeapons);

        }

        static void UpgradeAllWeapons(List<Weapon> prToUpgrade)
        {

            //static void UpgradeAllWeapons(Weapon weaponUpgrade)
            //{
            //foreach (Weapon weaponUpgrade in Weapon)
            //{
            //    switch (weaponUpgrade.WeaponType)
            //    {
            //        case WeaponType.Gun:
            //            weaponUpgrade.DamageDealt += 12;
            //            break;
            //        case WeaponType.Magic:
            //            weaponUpgrade.DamageDealt += 5;
            //            break;
            //        case WeaponType.Blade:
            //            weaponUpgrade.DamageDealt += 10;
            //            break;
            //    }

            //}


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
            }
            /*   switch (weaponUpgrade.WeaponType)
               {
                   case WeaponType.Gun:
                       weaponUpgrade.DamageDealt += 12;
                       break;
                   case WeaponType.Magic:
                       weaponUpgrade.DamageDealt += 5;
                       break;
                   case WeaponType.Blade:
                       weaponUpgrade.DamageDealt += 10;
                       break;
               }
           }*/
        }
    }
}
