using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht15
{
    class Program
    {
        static void Main(string[] args)
        {
            int input, i, j, k, width, tempWidth, layers = 1;

            Console.Write("Give height of tree >-> ");
            string line = Console.ReadLine(); // Read users input
            input = int.Parse(line); // Store input

            input = input - 3;         // Get the width of the lowest level
            width = (input) * 2 + 1; 
            tempWidth = (input) * 2 + 1; // Unchanged width to ensure we can get the two asterisk tall tree trunk
   

            do // How many layers ->
            {
                width = width - 2;
                layers++;

            } while (width != 1); // Do until width is different than one

   

            // How many spaces are needed on top = width / 2 - 1
            // How many spaces are needed on each layers to achieve shape = width / 2 - 2, 3, 4 etc.

            for (i = 0; i < layers; i++)
            {
                for (j = layers; j > i; j--)
                {
                    Console.Write(" ");
                }

                for (k = 0; k < i * 2 + 1; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            } 

            // Lastly we need a two asterisks tall tree trunk

            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < tempWidth / 2 + 1; j++)
                {      // tempWidth works as the untouched width
                    Console.Write(" ");
                }
                Console.WriteLine("*");
            }


        }
    }
}
