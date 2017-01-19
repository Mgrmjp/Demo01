using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht03
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2, number3;
            Console.Write("Give first number < ");
            string line = Console.ReadLine(); //read input
            number1 = int.Parse(line); // parse input "1" -> 1

            Console.Write("Give second number < ");
            line = Console.ReadLine(); //read input
            number2 = int.Parse(line); // parse input "2" -> 2

            Console.Write("Give third number < ");
            line = Console.ReadLine(); //read input
            number3 = int.Parse(line); // parse input "3" -> 3

            Console.Write("The sum is: " + (number1 + number2 + number3) + Environment.NewLine);


            Console.Write("The average is: " + ((number1 + number2 + number3) / 3) + Environment.NewLine);

            Console.ReadLine();
        }
    }
}
