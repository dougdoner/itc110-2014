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
        /// Part 1
        /// Creating an array of 50 random inegers. Then looping through the array and outputting a count of how many of the array elements are even numbers
        /// Authored by Douglas Doner
        /// Date: 10/22/2014
        /// </summary>
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] randomInt = new int[50];
            int evenCounter = 0;

            for (int i = 0; i < randomInt.Length; i++)
            {
                randomInt[i] = rand.Next(1, 101);
            }

            foreach (int i in randomInt)
            {
                if (i % 2 == 0)
                {
                    evenCounter++;
                }
            }

            Console.WriteLine("There were {0} even numbers in the random number array", evenCounter);
            Console.ReadKey();
        }
    }
}
