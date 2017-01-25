using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht17
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 12, 14, 18, 20, 22, 24 };
            int[] arr2 = { 11, 13, 15, 17, 19, 23 };


            // Print table 1
            Console.Write("Numbers in table one: ");
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write(" {0} ", arr1[i]);
            }

            Console.WriteLine();

            // Print table 2
            Console.Write("Numbers in table two: ");
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write(" {0} ", arr2[i]);
            }

            Console.WriteLine();

            // Combine both tables into a new one
            int[] arr3 = new int[arr1.Length + arr2.Length];
            arr1.CopyTo(arr3, 0);
            arr2.CopyTo(arr3, arr1.Length);

            Array.Sort(arr3); // Sort table 3 to be: smallest number -> biggest

            // Print combined table
            Console.Write("The combined chart is:");
            for (int i = 0; i < arr3.Length; i++)
            {
                Console.Write(" {0} ", arr3[i]);
            }
            Console.ReadLine();
        }
    }
}
