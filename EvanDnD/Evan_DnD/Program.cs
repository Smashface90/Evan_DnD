/*
 * DnD type character creator
 * Written by: Evan Waters. M124566
 * 
 * Designed to create a character with a race, class, set stats and some random items and weapons
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Evan_DnD
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //User types this
        String playerName;
        //set from int choice
        String playerRace;
        //set from into choice
        String playerClass;
        //Male Female NB
        String playerSex;
        //playerPronoun    
        String playerPronoun;
        String weaponName;

        //this is used to select race
        int raceNumber;
        //this is to determine the characters sex
        int sexNumber;
        //this is to select class
        int classNumber;
        //this is the race health stat
        int raceHealth;
        //this is the class base health
        int classHealth;
        //race + class + 2
        int playerHealth;
        //luck = weapon dmg *2    
        int playerLuck;
        int playerStam;
        int playerChar;

        float weaponDmg;

        //if input has been typed out with inparse.
        bool kbInput;


            //----------------------------Script starts here-------------------------------
            //players name seq
            //Using foregroundcolor everywhere to keep as white. There are red parts in some areas to show errors, but dont want to change the script perma to red
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Welcome to the Mini DnD Character Creator");
            Console.WriteLine(" ");
            Console.WriteLine("Written by: Evan Waters");
            Console.WriteLine("Version: 0.1");
            Console.WriteLine("-------------------------------------------\n");
            Console.WriteLine("Please type the name of your character: \n");
            playerName = Console.ReadLine();

            //players sex seq
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("What is " + playerName + "'s sex?");
            Console.WriteLine("-------------------------------------------\n");
            Console.WriteLine(" 1) Male\n 2) Female\n 3) Non-Binary");
            //triggers if an int is detected from the users input
            kbInput = int.TryParse(Console.ReadLine(), out sexNumber);

            //case switch depending on number
            if (kbInput)
            {
                switch (sexNumber)
                {
                    case 1:
                        playerSex = "Male";
                        playerPronoun = "his";
                        break;
                    case 2:
                        playerSex = "Female";
                        playerPronoun = "her";
                        break;
                    case 3:
                        playerSex = "Non-Binary";
                        playerPronoun = "their";
                        break;
                    //failsafe if not the right int
                    default:
                        playerSex = "Null";
                        playerPronoun = "Null";
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(sexNumber + " is not an option");
                        Console.ReadLine();
                        break;
                }
            }
            else
            //failsafe if not even an int
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Not a number. Error");
                playerSex = "Null";
                playerPronoun = "Null";
                Console.ReadLine();
            }

            //essentually a new page. This time this is the race delaration
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("What race is " + playerName + " ?");
            Console.WriteLine("Please type in one of the following numbers");
            Console.WriteLine("-------------------------------------------\n");
            Console.WriteLine(" 1) Human\n 2) Orc\n 3) Fae\n 4) Goblin\n 5) Dwarf\n 6) High Elf \n 7) Tabaxi");
            kbInput = int.TryParse(Console.ReadLine(), out raceNumber);

            if (kbInput)
            {
                switch (raceNumber)
                {
                    case 1:
                        playerRace = "Human";
                        raceHealth = 11;
                        break;

                    case 2:
                        playerRace = "Orc";
                        raceHealth = 13;
                        break;

                    case 3:
                        playerRace = "Fae";
                        raceHealth = 5;
                        break;

                    case 4:
                        playerRace = "Goblin";
                        raceHealth = 8;
                        break;

                    case 5:
                        playerRace = "Dwarf";
                        raceHealth = 10;
                        break;

                    case 6:
                        playerRace = "High Elf";
                        raceHealth = 12;
                        break;

                    case 7:
                        playerRace = "Tabaxi";
                        raceHealth = 7;
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(raceNumber + " is not an option");
                        playerRace = "Null";
                        raceHealth = 0;
                        Console.ReadLine();
                        break;
                }
            }

            else

            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Not a number. Error");
                playerRace = "Null";
                raceHealth = 0;
                Console.ReadLine();
            }

            //this is the class page. Now using bits of information that has been gathered. such as name, gender, pronouns and race.
            Console.Clear();
            Console.ForegroundColor= ConsoleColor.White;
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine(playerName + ", the " + playerSex + " " + playerRace);
            Console.WriteLine("What is " + playerPronoun + " class?");
            Console.WriteLine("Please type in one of the following numbers");
            Console.WriteLine("-------------------------------------------\n");
            Console.WriteLine(" 1) Warrior\n 2) Mage\n 3) Cleric\n 4) Ranger\n 5) Necromancer\n 6) Druid");
            //triggers if an int is detected from the users input
            kbInput = int.TryParse(Console.ReadLine(), out classNumber);

            //case switch depending on number
            if (kbInput)
            {
                switch (classNumber)
                {
                    case 1:
                        playerClass = "Warrior";
                        classHealth = 8;
                        weaponName = "FaceBreaker";
                        weaponDmg = 13.28f;
                        break;
                    case 2:
                        playerClass = "Mage";
                        classHealth = 2;
                        weaponName = "Wand of Gamelon";
                        weaponDmg = 14.02f;
                        break;
                    case 3:
                        playerClass = "Cleric";
                        classHealth = 4;
                        weaponName = "Staff of Jamboya";
                        weaponDmg = 2.00f;
                        break;
                    case 4:
                        playerClass = "Ranger";
                        classHealth = 5;
                        weaponName = "Bow of Spears";
                        weaponDmg = 12.21f;
                        break;
                    case 5:
                        playerClass = "Necromancer";
                        classHealth = 1;
                        weaponName = "Xelan's Skull";
                        weaponDmg = 27.11f;
                        break;
                    case 6:
                        playerClass = "Druid";
                        classHealth = 7;
                        weaponName = "Staff of howling wind";
                        weaponDmg = 14.20f;
                        break;

                    //failsafe if not the right int
                    default:
                        playerClass = "Null";
                        classHealth = 0;
                        weaponName = "Null";
                        weaponDmg = 0;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(classNumber + " is not an option");
                        Console.ReadLine();
                        break;
                }
            }
            else
            //failsafe if not even an int
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Not a number. Error");
                playerClass = "Null";
                classHealth = 0;
                weaponName = "Null";
                weaponDmg = 0;
                Console.ReadLine();
            }

            //--------------------------------Stat Calculation section---------------------------------
            //player health
            playerHealth = (raceHealth + classHealth + 2);
            playerStam = playerHealth * 2 - 3;
            playerLuck = (int)(weaponDmg /3);
            playerChar = playerStam + playerLuck + 5;

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Character Sheet");
            Console.WriteLine("-------------------------------------------\n");
            Console.WriteLine(playerName + ", the " + playerSex + " " + playerRace + " " + playerClass + ".\n");
            Console.WriteLine("Stats");
            Console.WriteLine("______");
            Console.WriteLine("Level: 3");
            Console.WriteLine("Health: " + playerHealth);
            Console.WriteLine("Stamina: " + playerStam);
            Console.WriteLine("Charisma: " + playerChar);
            Console.WriteLine("Luck: " + playerLuck);
            Console.WriteLine(" ");
            Console.WriteLine("Items");
            Console.WriteLine("_____");
            Console.WriteLine("Main Hand Weapon: " + weaponName);
            Console.WriteLine("Weapon Damage: " + weaponDmg);
            Console.ReadLine();
        }
    }
}
