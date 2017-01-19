using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht4
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;

            Console.WriteLine("Give your age > ");
            age = int.Parse(Console.ReadLine());

            if (age < 18) Console.WriteLine("Underage");
            else if (age >= 18 && age <= 65) Console.WriteLine("Adult");
            else if (age > 65) Console.WriteLine("Senior");
                
        }
    }
}
