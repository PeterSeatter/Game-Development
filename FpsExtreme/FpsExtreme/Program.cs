using System;

namespace FpsExtreme
{
    class Program
    {
        public static void Main(string[] args)
        {
            ///Reduces the lines of code in the Main program which in turn enables code to be kept track of easily
            CreationWithDisplay();
        }

        /// This method is the creation of each Character and then displays it on the screen for the user to see
        public static void CreationWithDisplay()
        {
            ///In creation of variable having lc infront of the name refer to it being local and only for that method
            Character lcDeanKeaton = new Character("Dean Keaton", Character.CharacterType.TeamMember, 15, 4, 5);
            Character lcKeizerSoze = new Character("Keizer Soze", Character.CharacterType.Enemy, 100, 2, 15);
            Character lcToddHockney = new Character("Todd Hockney", Character.CharacterType.TeamMember, 25, 2, 10);
            Character lcEdieFinneran = new Character("Edie Finneran", Character.CharacterType.Civilian, 90, 1, 30);

            Console.WriteLine("**** Welcome to FPS Extreme ****");
            Console.WriteLine();
            Console.WriteLine("The Characters in this game are: ");
            Console.WriteLine();
            DisplayCharacterDetails(lcDeanKeaton);
            DisplayCharacterDetails(lcKeizerSoze);
            DisplayCharacterDetails(lcToddHockney);
            DisplayCharacterDetails(lcEdieFinneran);
            Console.WriteLine();
            SpendAllGameCredit(lcDeanKeaton);
            Console.WriteLine();
            SpendAllGameCredit(lcEdieFinneran);
        }

        ///This keeps track of the game credits of the character so then if they would like to spend it then it will execute what's inside by calling the SpendCredits and GetGameCredit method from the Character class 
        public static void SpendAllGameCredit(Character prCharacter)
        {
            if (prCharacter.GetGameCredit() > 0)
            {
                Console.WriteLine("{0} is spending all the game credits", prCharacter.GetName());

                while (prCharacter.SpendCredits() > 0) { }
                Console.WriteLine("{0}'s updated details: ", prCharacter.GetName());
                DisplayCharacterDetails(prCharacter);

            }
            else
            {
                //lets the user know that they are out of credits if they try to have user credits they don't have
                Console.WriteLine("The character is out of credits");
            }
        }

        ///This holds the method which displays the character details and it calls on the character class with parameter called prCharacter which defines it as a parameter so the code inside this Method works properly.
        public static void DisplayCharacterDetails(Character prCharacter)
        {
            Console.WriteLine("{0}, Type: {1},  Health: {2}, Weapon Effect: {3}, Game Credits: {4};", prCharacter.GetName(), prCharacter.GetCharacterType(), prCharacter.GetHealth(), prCharacter.GetWeaponEffect(), prCharacter.GetGameCredit());
        }
    }
}
