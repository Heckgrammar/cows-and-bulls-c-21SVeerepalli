using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CowsAndBulls
{
    internal class Program
    {
        static void Main(string[] args)
        {
                    Random random = new Random();
        int number;

        do
        {
            number = random.Next(1000, 10000);
        } while (number.ToString().Distinct().Count() < 4 || number.ToString()[0] == '0');
        int cows, bulls;

        do

        {

            Console.WriteLine("Enter your guess (4 digits): ");
            string userGuess = Console.ReadLine();
            while (userGuess.Length != 4 || userGuess[0] == '0' || userGuess.Distinct().Count() < 4)

            {

                Console.WriteLine("Invalid guess. Please enter again (4 digits, not start with zero): ");
                userGuess = Console.ReadLine();
            }
            cows = 0;
            bulls = 0;

            for (int i = 0; i < 4; i++)

            {

                if (userGuess[i] == number.ToString()[i])
                    bulls++;
                else if (number.ToString().Contains(userGuess[i]))
                    cows++;

            }



            Console.WriteLine($"Cows: {cows}, Bulls: {bulls}");
        } while (bulls != 4);
        Console.WriteLine("Congratulations! You guessed it right!");


    }
}
}


        }
    }
}
