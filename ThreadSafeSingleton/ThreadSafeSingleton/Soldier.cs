using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadSafeSingleton
{
    class Soldier
    {
        public int Health { get; set; }

        // constructor
        public Soldier(int prHealth)
        {
            Health = prHealth;
        }
    }
}
