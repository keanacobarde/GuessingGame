using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    internal class Globals
    {
        
        // Greeting Function
        public static void Greeting()
        {
            Console.WriteLine("Welcome to Guessing Game!");
        }

        // Difficulty Levels Function
        public static List<DifficultyClass> difficultyClasses = new List<DifficultyClass>()
        {
            new DifficultyClass()
            { 
                Difficulty = "Easy",
                AmountGuesses = 8,
            },
            new DifficultyClass()
            {
                Difficulty = "Medium",
                AmountGuesses = 6,
            },
            new DifficultyClass()
            {
                Difficulty = "Hard",
                AmountGuesses = 4,
            },

        };

        // Amount to Guess
        public static int guesses = 0;

        // Difficulty Level Querying
        public static void DifficultyMenu()
        {
            string choice = null;

            while (choice != "0")
            {
                Console.WriteLine(@"Choose an option: 
                      0. Exit
                      1. Easy
                      2. Medium 
                      3. Hard
                      4. Cheater");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "0":
                        Console.WriteLine("Goodbye");
                        break;
                    case "1":
                        Console.WriteLine($"{difficultyClasses[0].Difficulty} mode. You get {difficultyClasses[0].AmountGuesses} guesses.");
                        Globals.guesses = difficultyClasses[0].AmountGuesses;
                        break;
                    case "2":
                        Console.WriteLine($"{difficultyClasses[1].Difficulty} mode. You get {difficultyClasses[1].AmountGuesses} guesses.");
                        Globals.guesses = difficultyClasses[1].AmountGuesses;
                        break;
                    case "3":
                        Console.WriteLine($"{difficultyClasses[2].Difficulty} mode. You get {difficultyClasses[2].AmountGuesses} guesses.");
                        Globals.guesses = difficultyClasses[2].AmountGuesses;
                        break;
                    case "4":
                        Console.WriteLine($"Cheater mode. You get unlimited guesses");
                        break;

                }

                break; 
            
            }
        
        }


        // Game Loop - No Difficulty
        public static void GameLoop()
        {
            int SecNum = SecretNumber.SecretNumberGenerator();
            int attempts = 0;
            while (attempts < Globals.guesses)
            {
                Console.WriteLine("Guess a number");
                int UserNumber = int.Parse(Console.ReadLine());
                Console.WriteLine($"Your Guess ({attempts + 1}) > {UserNumber}");
                if (UserNumber == SecNum)
                {
                    Console.WriteLine("You guessed it!");
                    break;
                }
                else if (UserNumber < SecNum)
                {
                    Console.WriteLine("Your guess is too low");
                    Console.WriteLine($"You have {Globals.guesses - attempts} guess(es) left");
                    attempts++;
                }
                else if (UserNumber > SecNum)
                { 
                    Console.WriteLine("Your guess is too high");
                    Console.WriteLine($"You have {Globals.guesses - attempts} guess(es) left");
                    attempts++;
                }

            }

        }
    }
}
