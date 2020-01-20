using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadSafeSingleton
{
    public class Medic
    {
        private static readonly Medic healthSupply = new Medic();

        private Medic() { }

        public static Medic HealthSupply
        {
            get
            {
                return healthSupply;
            }
        }

        public int GiveHealth(int prPlayerCurrentHealth)
        {

            if (prPlayerCurrentHealth > 90)
                // do nothing
                return 0;

            if (prPlayerCurrentHealth > 30)
                return 10;

            if (prPlayerCurrentHealth > 0)
                return 30;

            // else
            throw new ArgumentException("Error, player current health value is invalid.");
        }
    }
}
