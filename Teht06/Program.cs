using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht06
{
    class Program
    {
        static void Main(string[] args)
        {
            int trip;
            double usage;
            double cost;
            Console.WriteLine("Give the lenght of the trip > ");
            trip = int.Parse(Console.ReadLine());

            usage = ((7.02 / 100) * trip);

            cost = (usage * 1.595);

            Console.WriteLine("The amount of gas used is " + usage + " liters" + ", and the cost is "  + Math.Round(cost, 2) + " euros."); // Round cost using Math.Round
        }
    }
}
