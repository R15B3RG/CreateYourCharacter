using CreateYourCharacter;
using CreateYourCharacter.Character;
using CreateYourCharacter.Character.CharacterClass;
using CreateYourCharacter.Character.Race;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;
using OpenAI;


public class CharacterCreator
{
    static void Main(string[] args)
    {
        CharacterCreator characterCreator = new CharacterCreator();

        Character character = new Character();

        characterCreator.Creator(character);
    }

    void Creator(Character character)
    {
        Console.WriteLine("Welcome to the Character creator!"
            +"\n"
            +"\n Press enter to continue...");
        Console.ReadKey();

        bool gender = true;

        while (gender)
        {
            Console.Clear();

            Console.WriteLine("Select your gender:"
            + "\n"
            + "\n"
            + "\n 1. Male"
            + "\n 2. Female");

            string genderInput = Console.ReadLine();

            if (genderInput == "1")
            {
                character.Gender = "Male";
                gender = false;
                break;
                
            }
            else if (genderInput == "2")
            {
                character.Gender = "Female";
                gender = false;
                break;
            }
            else
            {
                Console.WriteLine("Wrong input! Try again!");

                genderInput = Console.ReadLine();
            }
        }

        bool classChoice = true;

        while (classChoice)
        {
            Console.Clear();

            Console.WriteLine("Select your class:"
            + "\n"
            + "\n"
            + "\n 1. Knight"
            + "\n 2. Mage"
            + "\n 3. Ranger");

            string classInput = Console.ReadLine();

            if (classInput == "1")
            {
                character.characterClass = new Knight();
                
                classChoice = false;
                

            }

            else if (classInput == "2")
            {
                character.characterClass = new Mage();
                classChoice = false;
                break;
            }

            else if (classInput == "3")
            {
                character.characterClass = new Ranger();
                classChoice = false;
                break;
            }

            else
            {
                Console.WriteLine("Wrong input! Try again!");

                classInput = Console.ReadLine();
            }
        }

        bool race = true;

        while (race) 
        { 
            Console.Clear();

            Console.WriteLine("Select your race:"
            + "\n"
            + "\n"
            + "\n 1. Human"
            + "\n 2. Elf"
            + "\n 3. Dwarf");

            string raceInput = Console.ReadLine();

            if (raceInput == "1")
            {
                character.race = new Human();
                race = false;
                break;
            }

            else if(raceInput == "2")
            {
                character.race = new Elf();
                race = false;
                break;
            }

            else if (raceInput == "3")
            { 
                character.race = new Dwarf();
                race = false;
                break;
            }

            else
            {
                Console.WriteLine("Wrong input! Try again!");

                raceInput = Console.ReadLine();
            }
        }

        bool charName = true;

        while (charName) 
        {
            Console.Clear();

            Console.WriteLine("Name you character:");

            string nameInput = Console.ReadLine();

            if (nameInput is null || nameInput == string.Empty)
            {
                Console.WriteLine("Your character needs a name, please provide one.");

                nameInput = Console.ReadLine();
            
            }
            else
            {
                character.CharacterName = nameInput;
                break;
            }
        }

        Console.Clear();

        Console.WriteLine($"Is this your character?"
            + "\n"
            + $"\n Name: {character.CharacterName}"
            + $"\n Gender: {character.Gender}"
            + $"\n Class: {character.characterClass}"
            + $"\n Race: {character.race}"
            + "\n"
            + "\n"
            + "\n 1. Yes"
            + "\n 2. No");

        string choiceInput = Console.ReadLine();

        if (choiceInput == "1")
        { 
            
        }
        else if (choiceInput == "2")
            {
            Console.Clear();
            CharacterCreator characterCreator = new CharacterCreator();
            character = new Character();
            characterCreator.Creator(character);
        }
        
    }
}