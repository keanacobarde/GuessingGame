using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    internal class Cheater
    {
        public static void CheaterGameLoop()
        {
            int SecNum = SecretNumber.SecretNumberGenerator();
            int UserNumber = 0;
            while (SecNum != UserNumber)
            {
                Console.WriteLine("Guess a number");
                UserNumber = int.Parse(Console.ReadLine());
                if (UserNumber == SecNum)
                {
                    Console.WriteLine("You guessed it!");
                    break;
                }
                else if (UserNumber < SecNum)
                {
                    Console.WriteLine("Your guess is too low");
                }
                else if (UserNumber > SecNum)
                {
                    Console.WriteLine("Your guess is too high");
                }

            }
        }
    }
}
