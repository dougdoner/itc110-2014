using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itc110assignment_5
{
    class Program
    {
        /// <summary>
        /// This is for assignment-5
        /// Part 3
        /// Creating an array of 10 doubles. Prompting a user to enter numbers into the array. After all the numbers have been entered display all the numbers in the array, the total numbers and the average.
        /// Authored by Douglas Doner
        /// Date: 10/22/2014
        /// </summary>
        static void Main(string[] args)
        {
            double[] numberArray = new double[10];
            bool goodDouble = false;
            double counter = 0;

            for (int i = 0; i < numberArray.Length; i++)
            {
                do
                {
                    Console.WriteLine("Enter a number.");
                    goodDouble = double.TryParse(Console.ReadLine(), out numberArray[i]);
                } while (!goodDouble && i < numberArray.Length);
                counter += numberArray[i];
            }

            for (int i = 0; i < numberArray.Length; i++)
            {
                Console.WriteLine(numberArray[i]);
            }

            Console.WriteLine("The number total is: {0}", counter);
            Console.WriteLine("This average of the array is: {0}", counter / numberArray.Length);

            Console.ReadKey();
        }
    }
}
