using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass1012014
{
    class Program
    {
        /* This is for in-class 10/1/20214
         * part 1
         * Selection examples
         * Date: 10/1/2014
         */
        static void Main(string[] args)
        {
            string pass = "Hello";
            Console.WriteLine("Enter in the password");
            string userPass = Console.ReadLine();
            //pass.Equals is the function for string comparison
            if (pass.Equals(userPass))
            {
                Console.WriteLine("Thank you");
            }
            else
            {
                Console.WriteLine("Sorry");
                Console.ReadKey();
                return;
            }

            int number;
            Console.WriteLine("Enter a number");
            //declares a boolean goodNumber, used for int.TryParse to test if parse worked. out number is an out parameter
            bool goodNumber = int.TryParse(Console.ReadLine(), out number);
            //if the TryParse returns false, require user to restart application and enter a correct integer
            if (!goodNumber)
            {
                Console.WriteLine("Restart, and enter in a valid integer.");
                Console.ReadKey();
                return;
            }

            //if statement, tests a value against a condition, in this case tests the int variable against the number 21
            if (number == 21) 
            {
                Console.WriteLine("Drinks too much");
            }
            //if the variable isn't equal to 21, variable is tested for if it is greater than 21
            else if (number > 21)//resolves to a boolean, true or false
            {
                Console.WriteLine("Old enough to drink");
            }
            //fall-back for all values that don't fall into the other if statements
            else
            {
                Console.WriteLine("Not old enough to drink");
            }
            Console.ReadKey();
        }
    }
}
