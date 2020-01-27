namespace FpsExtreme
{
    class Character
    {
        private string name;
        private int health;
        private int weaponEffect;
        private int gameCredit;
        private CharacterType characterType;
        public enum CharacterType
        {
            TeamMember,
            Enemy,
            Civilian
        }

        /// This constructor enables the creation of the Character variable while refering to each element with a pr infront which is refered as peremeter and it's easily identifiable when reading through lines of code for methods.
        public Character(string prName, CharacterType prCharacterType, int prHealth, int prWeaponEffect, int prGameCredit)
        {
            name = prName;
            characterType = prCharacterType;
            health = prHealth;
            weaponEffect = prWeaponEffect;
            gameCredit = prGameCredit; 
        }

        public string GetName()
        {
            return name;
        }

        public int GetHealth()
        {
            return health;
        }

        public int GetWeaponEffect()
        {
            return weaponEffect;
        }

        public int GetGameCredit()
        {
            return gameCredit;
        }

        ///This public method has a switch statement in place which will return the string which it's to return and won't execute other cases        
        public string GetCharacterType()
        {
            //This identifies the switch and refers to the enumerator so it can check it so the cases can be run
            switch (characterType)
            {
                case CharacterType.TeamMember:
                    return "Team Member";
                    break;

                case CharacterType.Enemy:
                    return "Enemy";
                    break;

                case CharacterType.Civilian:
                    return "Civilian";
                    break;
                
                //Just to state that the person has no Character type if one isn't defined for them already
                default:
                    return "No Character Type";
            }
        }

        /// This checks the credits and as a result it will subtract a credit and then it will add the required amount as along as gameCredit is greater than zero
        public int SpendCredits()
        {
            if (gameCredit > 0)
            {
                switch (characterType)
                {
                    case CharacterType.TeamMember:
                        weaponEffect += 1;
                        break;

                    case CharacterType.Enemy:
                        weaponEffect += 1;
                        break;

                    case CharacterType.Civilian:
                        health += 5;
                        break;
                }
                gameCredit--;
                return gameCredit;
            }
            return 0;
        }

    }
}
