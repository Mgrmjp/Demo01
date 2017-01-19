using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht09
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;

            do
            {
                Console.WriteLine("Give a number < ");
                number = int.Parse(Console.ReadLine());

            } while (number != 0);

        }
    }
}
