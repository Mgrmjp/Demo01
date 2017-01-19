using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht07
{
    class Program
    {
        static void Main(string[] args)
        {
            int year;
            Console.WriteLine("Give a year > ");
            year = int.Parse(Console.ReadLine());

            if (year % 4 == 0 && year % 100 != 0 || (year % 400 == 0))

            {
                Console.WriteLine(year + " is a leap year.");
            }

            else

            {
                Console.WriteLine(year + " is not a leap year.");
            }
        }
    }
}
