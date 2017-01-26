using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht20
{
    class Program
    {
        static void Main(string[] args)
        {
            int ownage;
            int womage;

            Console.Write("Give your age << ");
            string line = Console.ReadLine();
            bool result1 = int.TryParse(line, out ownage);

            Console.Write("Give age of woman << ");
            line = Console.ReadLine();
            bool result2 = int.TryParse(line, out womage);

            if (result1 && result2 == true)
            {

                if (womage - ownage >= 10)
                {
                    Console.WriteLine();
                    Console.WriteLine("Woman is a cougar, good luck.");
                    Console.WriteLine(@"                  /  __  \ ");
                    Console.WriteLine(@" / \ ----/ \     / /    \ \");
                    Console.WriteLine(@"                 \/      \ \");
                    Console.WriteLine("  < >   < >              | |");
                    Console.WriteLine(@"\     ^     /------------| |");
                    Console.WriteLine(@"  \  -^-  /        ____    |");
                    Console.WriteLine(@" |   ---          /    \   |");
                    Console.WriteLine(" |                      |  |");
                    Console.WriteLine(@"  \--  \         /------|  /");
                    Console.WriteLine("   --------------_________/");
                    Console.WriteLine();

                }

                else
                {
                    Console.WriteLine("\nUnfortunately woman is not a cougar, look elsewhere.\n");
                }
            }
            else
            {
                Console.WriteLine("Not a valid input!");
            }
        }
    }
}