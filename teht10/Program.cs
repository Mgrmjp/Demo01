using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 33, 44, 55, 68, 77, 96, 100 }; // initialize array with given numbers


            for (int i = 0; i < numbers.Length; i++) // check number in each given array spot
            {
                if (numbers[i] % 2 == 0) // if remainder is zero print HEP after number
                {

                    Console.WriteLine(numbers[i] + " HEP!");

                } else Console.WriteLine(numbers[i]); // if remainder is not 0 just print it by itself

            }
            Console.WriteLine();
        }
    }
}
