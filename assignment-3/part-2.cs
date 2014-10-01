using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3Part2
{
    class Program
    {
        /* This is for assignment 3
         * part-2
         * Having the user enter a number. If it is even the output is "Even," if odd, the output is "Odd."
         * Authored by Douglas Doner
         * Date: 10/1/2014
         */
        static void Main(string[] args)
        {
            int number;

            Console.WriteLine("Enter in a whole number to see if it is even or odd.");
            number = int.Parse(Console.ReadLine()) % 2;
            if (number == 0)
            {
                Console.WriteLine("Your number is even");
            }
            else
            {
                Console.WriteLine("Your number is odd");
            }
            Console.ReadKey();
        }
    }
}
