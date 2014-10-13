using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itc110assignment_4
{
    class Program
    {
        /* This is for assignment-4
         * part-3
         * Creating a while loop that displays the count of the loops and then asks the user whether they want to continue or not. If yes, the continue; if no the program should end and display a note saying thank you
         * Authored by Douglas Doner
         * Date: 10/13/2014
         */
        static void Main(string[] args)
        {

            int counter = 0;
            string keepGoing = "yes";
            while (keepGoing.Equals("Yes") || keepGoing.Equals("yes"))
            {
                counter++;
                Console.WriteLine("You have looped {0} times. Would you like the loop to keep going?", counter);
                keepGoing = Console.ReadLine();
            }
        }
    }
}
