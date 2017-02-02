using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            int i, number;

            for (i = 0; i < numbers.Length; i++)
            {
                Console.Write("Give a number - ");
                string input = Console.ReadLine(); // Read input
                number = int.Parse(input);
                numbers[i] = number;
            }

            Console.Write("Numbers - ");

            for (i = 4; i >= 0; i--)
            {
                Console.Write(numbers[i]); // Take care of extra dot
                if (i > 0)
                {
                    Console.Write(",");
                }
            }
            Console.WriteLine();
        }
    }
}
