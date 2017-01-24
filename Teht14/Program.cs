using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht14
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] grades = new int[8];

            for (int i = 0; i < grades.Length; i++)
            {
                Console.Write("Give a grade (0 - 5) < ");
                grades[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < grades.Length; i++)
            {
              

            }



        }
    }
}
