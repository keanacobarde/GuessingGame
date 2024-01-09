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

        // Game Loop - No Difficulty
        public static void GameLoop()
        {
            int SecNum = SecretNumber.SecretNumberGenerator();
            int attempts = 0;
            while (attempts < 4)
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
                    attempts++;
                }
                else if (UserNumber > SecNum)
                { 
                    Console.WriteLine("Your guess is too high");
                    attempts++;
                }
                else
                {
                    Console.WriteLine("Wrong!");
                    attempts++;
                }

            }

        }
    }
}
