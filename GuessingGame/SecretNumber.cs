using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    internal class SecretNumber
    {
        public static int SecretNumberGenerator()
        { 
            Random random = new Random();
            int SecretNum = random.Next(1, 100);
            return SecretNum;
        
        }
    }
}
