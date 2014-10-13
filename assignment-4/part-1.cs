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
         * part-1
         * Creating a loop that displays 10 random numbers.
         * Authored by Douglas Doner
         * Date: 10/13/2014
         */
        static void Main(string[] args)
        {
            Random rand = new Random();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(rand.Next(1, 200));
            }

            Console.ReadKey();
        }
    }
}
