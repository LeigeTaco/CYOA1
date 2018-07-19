using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CYOAGame1
{

    class Program
    {

        struct Attack                   //Spells, Weapons and Fisticuffs
        {

            public char damageType;     //Physical, Magic, Energy. Disease (Poison).
            public byte power;          //Modifier based on dexterity, strength, intellect.
            public byte hitRate;        //Based on dexterity only.
            public string name;         //Identifier ADD ALIASES.
            public byte speedModifier;  //Effects how many times it can be executed in a turn.
            public char contactType;    //Determines reflect damage interaction.
            public string weaponType;   //Sorta like flavor text.
            public string flavorText;   //Actually flavor text.

        }

        struct StatusMove               //TOX, PAR, SLP kinda stuff
        {

            public string name;         //Name of the effect
            //public 

        }

        struct characterStats
        {

            public short maxHealthPoints;
            public short currentHealthPoints;
            public short maxResourcePoints;
            public short currentResourcePoints;

            public byte strength;       //Melee modifier
            public byte intellect;      //Magic and crit bonus
            public byte speed;          //Actions per turn
            public byte dexterity;      //Accuracy and Dodge
            public byte charisma;       //Noncombat
            public byte stamina;        //Somethings will use this
            public byte vitality;       //Recovery?
            public byte resistance;     //Percent damage reduc?
            public byte fortitude;      //Flat damage reduc?
            public byte willpower;      //Magic, Mind and Death resist? That's pretty anime.

        }

        struct Character
        {

            public string name;
            public char gender;
            public char archetype;
            public char affinity;
            public byte affinityStrength;
            public characterStats statList;
            public byte currentStamina;

        }

        static bool CharacterPrompt()
        {

            bool whileBreak = false;
            string newPlayer;
            bool newChar = true;

            Console.WriteLine("Hello, welcome to my Choose your own adventure game.");
            Console.WriteLine("Would you like to create a character or use a preset?");

            do
            {

                newPlayer = Console.ReadLine().ToLower();

                if ((newPlayer == "new") || (newPlayer == "create") || (newPlayer == "new character") || (newPlayer == "create a new character") || (newPlayer == "create a character"))
                {

                    Console.WriteLine("Prepping character creator...");
                    newChar = true;
                    whileBreak = true;

                }

                else if ((newPlayer == "premade") || (newPlayer == "preset"))
                {

                    Console.WriteLine("Skipping character creation, are you sure? (Y/N)");

                    bool innerBreak = false;

                    do
                    {

                        char confirm = char.Parse(Console.ReadLine().ToLower());

                        if (confirm == 'y')
                        {

                            Console.WriteLine("Confirmed.");

                            newChar = false;
                            whileBreak = true;
                            innerBreak = true;

                        }

                        else
                        {

                            Console.WriteLine("Going to character creation...");

                            newChar = true;
                            whileBreak = true;
                            innerBreak = true;

                        }

                    } while (!innerBreak);

                }

            } while (!whileBreak);

            return newChar;

        }

        static void StoryTime()
        {

            string worldName = "PLACEHOLDER";
            //string list of faction/country names
            //string list of town names per faction

            Console.WriteLine($"Your character hasn't been born yet. In fact, we're gonna go back to the beginning of the {factionNames.Length} major factions.");
            Console.WriteLine($"This world, {worldName}, is a world much like ours. Large continents and plenty of water to sustain life on land or sea. There are deserts, there are jungles and forests, and it really is similar to our world. It's not our world, but similar.");

        }

        static Character CreatorStory(Character MC)
        {

            StoryTime();

            return MC;

        }

        static Character CharacterCreator()
        {

            bool newChar = CharacterPrompt();

            if (newChar)
            {

                //Begin new character creation
                Character player = new Character();
                Console.WriteLine("Let's start with the easy stuff, what gender is your character? (M/F)");
                string temp = Console.ReadLine();
                player.gender = Char.ToLower(Char.Parse(temp));
                if(player.gender == 'm')
                {

                    Console.WriteLine("What's his name?");

                }
                else if(player.gender == 'f')
                {

                    Console.WriteLine("What's her name?");

                }
                else
                {

                    Console.WriteLine("What's their name?");

                }

                player.name = Console.ReadLine();

                Console.WriteLine("Wow! What a cool, good, original name.");
                Console.WriteLine("Now things are gonna go a little differently, we're still making your character, we're just gonna tell a small story and add to the lore. That's really important, right? (You don't get a choice in this)");

                player = CreatorStory(player);

            }

            else if(!newChar)
            {

                //Presets here.

            }

        }

        static void Main(string[] args)
        {

            Random rng = new Random();



        }

    }

}
