using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give the hight of the pyramid: ");
            int height = int.Parse(Console.ReadLine()); // parse input ("10" -> 10)

            for (int i = 1; i <= height; i++) // loop to get height
            {

                for (int e = 1; e <= i; e++) // loop for inputting stars
                {
                    Console.Write("*");
                }

                Console.WriteLine(); // adds enter after each line to get the correct shape
            }

        }
    }
    }


