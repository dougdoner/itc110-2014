using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3Part3
{
    class Program
    {
        /* This is for assignment 3
         * part 3
         * Having the user enter a grade point between 0 and 4. Validating that the number is in the correct range then evaluating the number to assign a letter grade.
         * Authored by Douglas Doner
         * Date: 10/1/2014
         */
        static void Main(string[] args)
        {
            double grade;
            Console.WriteLine("Enter in a grade point");
            grade = double.Parse(Console.ReadLine());
            //tests if the variable is outside the range of valid grade points
            if (grade < 0 || grade > 4)
            {
                Console.WriteLine("Restart the program and enter in a valid grade point");
                Console.ReadKey();
                return;
            }
            //if the variable grade falls within the range of 0 and 4
            else
            {
                if (grade <= 0.9)
                {
                    Console.WriteLine("Your get an F");
                }
                else if (grade > 0.9 && grade <= 1.9)
                {
                    Console.WriteLine("You get a D");
                }
                else if (grade > 1.9 && grade <= 2.9)
                {
                    Console.WriteLine("You get a C");
                }
                else if (grade > 2.9 && grade <= 3.4)
                {
                    Console.WriteLine("You get a B");
                }
                else if (grade > 3.4)
                {
                    Console.WriteLine("You get an A. Smarty pants.");
                }
                Console.ReadKey();
            }
        }
    }
}
