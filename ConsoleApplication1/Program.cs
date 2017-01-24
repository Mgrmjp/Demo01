using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5]; // initializing used array

            for (int i = 0; i < numbers.Length; i++) // loop for asking numbers and inputting them into an array
            {
                Console.Write("Give a number: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            for (int i = numbers.Length - 1; i >= 0; i--) // loop for printing numbers in reverse (i starts from 5 and goes down to 0, reversing the numbers)
            {
                Console.Write(numbers[i] + " ");
            }
        }
    }
}
