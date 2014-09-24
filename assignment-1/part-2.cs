using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1Part2
{
    class Program
        /* assignment-1
         * part 2
         * taking in user's name, address, city, and zip code, and formatting output
         * authored by Douglas Doner
         * Date: 09/24/2014
         */
    {
        static void Main(string[] args)
        {
            //defining string variables
            string name;
            string address;
            string city;
            string state;
            string zipCode;

            //asking for user input, and assigning inputs to string variables
            Console.WriteLine("Enter your name");
            name = Console.ReadLine();
            Console.WriteLine("enter your address");
            address = Console.ReadLine();
            Console.WriteLine("enter your city");
            city = Console.ReadLine();
            Console.WriteLine("Enter your state");
            state = Console.ReadLine();
            Console.WriteLine("Enter your zip code");
            zipCode = Console.ReadLine();

            //using placeholders for substituting variables, then formatting using linebreaks (\n)
            Console.WriteLine("\n{0}\n{1}\n{2}, {3}, {4}", name, address, city, state, zipCode);
            Console.ReadKey();
        }
    }
}
