using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht05
{
    class Program
    {
        static void Main(string[] args)
        {
            int time;
            Console.WriteLine("Give time in seconds < ");
            time = int.Parse(Console.ReadLine());

            Console.WriteLine("Your time can also be written as " + (time / 3600) + " hours " + (time % 3600 / 60) + " minutes " + (time % 3600 % 60) + " seconds.");

        }
    }
}
