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
            int sum = 0, number;

            do // ask numbers
            {
                Console.Write("Give a number: (0 ends and gives sum)"); 

                number = int.Parse(Console.ReadLine());
                sum += number; // add given number to sum
                
            } while (number != 0); // stop if 0 is given

            Console.WriteLine("Total: " + sum); // show sum of given numbers

        }

    }
    }

