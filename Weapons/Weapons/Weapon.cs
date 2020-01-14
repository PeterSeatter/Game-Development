using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weapons
{
    class Weapon
    {
        private string name;
        private WeaponType weapon;
        private int damage;

        public string ItemName
        {
            get {return name;}
            set{name = value;}
        }

        public WeaponType WeaponType
        {
            get { return weapon; }
            set { weapon = value; }
        }

        public int DamageDealt
        {
            get { return damage; }
            set { damage = value; }
        }

        public Weapon()
        {
        }

        public Weapon(string name, WeaponType weapon, int damage)
        {
            ItemName = name;
            WeaponType = weapon;
            DamageDealt = damage;
        }
    }
}
