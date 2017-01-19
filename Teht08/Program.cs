using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht08
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2, number3;

            Console.WriteLine("Give 1st number > ");
            string line = Console.ReadLine();
            number1 = int.Parse(line);

            Console.WriteLine("Give 2nd number > ");
            line = Console.ReadLine();
            number2 = int.Parse(line);

            Console.WriteLine("Give 3rd number > ");
            line = Console.ReadLine();
            number3 = int.Parse(line);

            if (number1 >= number2 && number1 >= number3)
            {
                Console.WriteLine("Largest number is " + number1);
            }

            if (number2 >= number1 && number2 >= number3)
            {
                Console.WriteLine("Largest number is " + number2);
            }

            if (number3 >= number1 && number3 >= number2)
            {
                Console.WriteLine("Largest number is " + number3);
            }



        }
    }
}
