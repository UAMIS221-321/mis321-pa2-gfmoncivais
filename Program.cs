using System;
//using mis321_pa2_gfmoncivais.Interfaces;

namespace mis321_pa2_gfmoncivais
{
    class Program
    {
        static void Main(string[] args)
        {
            //PA 2 - Pirates of the Carribean-inspired 
            //menu things - 
            Character playerOne = new Character();
            Character playerTwo = new Character();

            string playerOne; string playerTwo;
            WelcomeMenu(playerOne, playerTwo);

        }

        public static void WelcomeMenu(string playerOne, string playerTwo)
        {
            //Get the user to pick an option of the menu 
            Console.WriteLine("\nWelcome to the Pirates of the Crimson Tide Game\n");
            Console.WriteLine("For this game, you'll need two players \nPlayer 1, please enter your name: ");
            string playerOne = Console.ReadLine();
            Console.WriteLine("Player two, please enter your name: ");
            string playerTwo = Console.ReadLine();

            Console.Clear();
            Console.WriteLine($"Welcome {playerOne} and {playerTwo} \n");
            Console.WriteLine("");
            Console.WriteLine("1) Start the Game \n2) Create Your Own Character ");
            Console.WriteLine("\nInput your option: ");
            int gameOption = int.Parse(Console.ReadLine());
            while(gameOption == true)
            {   if (gameOption = 1)
                {
                    Console.WriteLine("Alright Mateys...time to get started");
                    Game();
                }
                else if(gameOption = 2)
                {
                    Console.WriteLine("Who needs defaults anyways? Sending you to the generator!");
                    NewCharacter(); //will need to write into a file or something like that 
                }
                else
                {
                    Console.WriteLine($"Aht. Aht. Try Again {playerOne} and {playerTwo}");
                }
            }
        }

        public static void Game(string playerOne, string playerTwo)
        {
            Console.WriteLine($"\tPirates {playerOne} and {playerTwo} , time to choose a character");
            Console.WriteLine($"{playerOne}, you are up first. Here is the list of characters available");
            //read in the character list -- bc when they make a new one, it'll show up on the list purr
            List<Character> newCharacter = new List<Character>();
            StreamReader inFile = null;
            try
            {
                inFile = new StreamReader("character.txt");
            }
            catch(FileNotFoundException x)
            {
                Console.WriteLine("Something went wrong. ", x);
                return newCharacter; //?
            }

            string line = inFile.ReadLine(); //prime
            if(line != null) 
            {
                string[] temp = line.Split('#');
                string character = temp[0];
                newCharacter.Add(new Character(){character = character});
                line = inFile.ReadLine(); //update read
            }
            inFile.Close(); //close

        }
    }
}
