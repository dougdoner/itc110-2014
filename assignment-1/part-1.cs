using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1Part1
{
    class Program
    /* this is for assignment-1
    * part 1
    * entering name and email
    * Authored by Douglas Doner
    * Date: 9/24/2014
    */
    {
        static void Main(string[] args)
        {
            //defining string variables
            string firstName;
            string lastName;
            string email;

            //writes to console window, then saves user input to string variables
            Console.WriteLine("Enter your first name");
            firstName = Console.ReadLine();
            Console.WriteLine("Enter your last name");
            lastName = Console.ReadLine();
            Console.WriteLine("Enter your email");
            email = Console.ReadLine();

            //numbers in brackets are placeholders for variables, followed by the variables in the order of the numbers
            //displays output after
            Console.WriteLine("{0}, {1}--{2}", firstName, lastName, email);

            //waits for a key stroke, then ends program
            Console.ReadKey();

        }
    }
}
