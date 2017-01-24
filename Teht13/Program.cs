using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht13
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] points = new int[5];

            for (int i = 0; i < points.Length; i++)
            {
                Console.Write("Give points for jump (5): ");
                points[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Total points are = " + (points.Sum() - points.Max() - points.Min()) + " ");

            Console.WriteLine();
        }
    }
}
