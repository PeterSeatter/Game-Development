using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPatternMain
{
    public class SingletonPatternMain
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The amount in the charity account is ${Bank.CharityAccount.CharityBalance}");
            Console.WriteLine("Taking out $50 from the charity account.....");
            Bank.CharityAccount.DonateMoney(50);
            Console.WriteLine("The new balance in the charity account is ${Bank.CharityAccount.CharityBalance}");
            Console.WriteLine("Taking out more money, this time $20 from the charity account.....");
            Bank.CharityAccount.DonateMoney(20);
            Console.WriteLine("The new balance in the charity account is ${Bank.CharityAccount.CharityBalance}");
            Console.WriteLine("Hit any key to exit");
            Console.ReadKey();
        }
    }
}
