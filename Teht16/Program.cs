using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht16
{
    class Program
    {
        static void Main(string[] args)
        {

            int input;

            int tries = 0;

            Random rnd = new Random();

            int randomizer = rnd.Next(100); // Set a random number that is between 0 and 100

            do
            {

                Console.Write("Guess a number << "); // Read and save what the user has inputted
                string line = Console.ReadLine();
                input = int.Parse(line); 
               
                // Give a hint if number is bigger or smaller than randomizer

                if (randomizer < input) Console.WriteLine("Wanted number is SMALLER...");

                else if (randomizer > input) Console.WriteLine("Wanted number is BIGGER...");

                tries++; // On each cycle add +1 to tries

            } while (randomizer != input);

            Console.WriteLine("Congratulations! You guessed correctly in {0} tries!", tries); // Print succcess message and number of tries
        }
    }
}
