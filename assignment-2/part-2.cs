using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2Part2
{
    class Program
    {
        /* This is for assignment-2
         * part 2
         * Taking in two integers and ouputting the quotient (division) and the remainder, if any (modulus)
         * Authored by Douglas Doner
         * Date: 09/29/2014
         */
        static void Main(string[] args)
        {
            int numberOne, numberTwo, numberThree;

            Console.WriteLine("Enter an integer");
            numberOne = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter another integer");
            numberTwo = int.Parse(Console.ReadLine());

            numberThree = numberOne / numberTwo;
            //the output will be a whole number, because integers cannot store decimals
            Console.WriteLine("{0} / {1} = {2}", numberOne, numberTwo, numberThree);
            numberThree = numberOne % numberTwo;
            Console.WriteLine("{0} % {1} = {2}. If there is no remainder, the number will be zero", numberOne, numberTwo, numberThree);
            Console.ReadKey();
        }
    }
}
