using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht18
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            int check = 1; // Number goes unchanged during process -> is palindrome


            Console.Write("Give a word or sentence (No Space :D) << ");
            string word = Console.ReadLine();

            char[] charArray = word.ToCharArray(); // Save input into a table so it can be processed

            // Start checking table from different ends
            for (i = 0, j = charArray.Length - 1; i != j; j--, i++)
            {
                if (charArray[i] == charArray[j]) // Compare if both letters are the same
                {

                }
                else // If letters aren't same, set check as 0
                {
                    check = 0;
                }
            }

            // Print appropriate result
            if (check == 1) Console.Write("Word IS a palindrome.");

            else Console.Write("Word '{0}' is NOT a palindrome.");

        }
    }
}
