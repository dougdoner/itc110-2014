using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2Part1
{
    class Program
        /* this is for assignment-2
         * part 1
         * Taking in two integers and ouputting the sum, the difference and the product
         * Authored by Douglas Doner
         * Date: 09/29/2014
         */
    {
        static void Main(string[] args)
        {
            //declaring int variables, numberThree for storing solutions to equations
            int numberOne, numberTwo, numberThree;
            Console.WriteLine("Enter an integer");
            //using int.Parse to convert the string into an int, and storing inside numberOne variable
            numberOne = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter another integer");
            numberTwo = int.Parse(Console.ReadLine());
            numberThree = numberOne + numberTwo;
            Console.WriteLine("{0} + {1} = {2}", numberOne, numberTwo, numberThree);
            numberThree = numberOne = numberTwo;
            Console.WriteLine("{0} - {1} = {2}", numberOne, numberTwo, numberThree);
            numberThree = numberOne * numberTwo;
            Console.WriteLine("{0} * {1} = {2}", numberOne, numberTwo, numberThree);
            Console.ReadKey();

        }
    }
}
