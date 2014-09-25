using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1Part3
{
    class Program
        /* assignment-1
         * part 3
         * taking inputs from user for a madlib sentence and storing in string variables, then ouputting sentence with string variables substitued in
         * authored by Douglas Doner
         * Date: 09/24/2014
         */
    {
        static void Main(string[] args)
        {
            //defining string variables
            string noun;
            string place;
            string adjective;
            string verb;

            //asking user for input, and assigning input to string variables
            Console.WriteLine("Fill in the blanks for the following sentence: \"The __ went to the __ to __ the __ car\"");
            Console.WriteLine("Enter in a noun");
            noun = Console.ReadLine();
            Console.WriteLine("enter in a location");
            place = Console.ReadLine();
            Console.WriteLine("Enter in a verb");
            verb = Console.ReadLine();
            Console.WriteLine("Enter in an adjective");
            adjective = Console.ReadLine();

            //substitues in string variables and displays output
            Console.WriteLine("The {0} went to the {1} to {2} the {3} car", noun, place, verb, adjective);
            Console.ReadKey();
            
        }
    }
}
