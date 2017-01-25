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
            int[] grades = new int[6]; // Initialize array
            int i, j, grade;

            do
            {
                Console.Write("Give a grade that is between 0 and 5 (-1 prints results) << ");
                string syote = Console.ReadLine(); // Read given input
                grade = int.Parse(syote);

                switch (grade)
                {
                    case 0: grades[0] = grades[0] + 1; break;
                    case 1: grades[1] = grades[1] + 1; break;
                    case 2: grades[2] = grades[2] + 1; break;
                    case 3: grades[3] = grades[3] + 1; break;
                    case 4: grades[4] = grades[4] + 1; break;
                    case 5: grades[5] = grades[5] + 1; break;
                    case -1: break; 
                    default: Console.WriteLine("Not a valid number."); break; // Feedback if a valid input is not given
                }

            } while (grade != -1); // If -1 is given, stop program


            // Print asterisks and result

            Console.WriteLine("Grades -- ");

            for (i = 0; i < 6; i++)
            {
                
                Console.Write(i);
                Console.Write(": ");

                for (j = 0; j < grades[i]; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
