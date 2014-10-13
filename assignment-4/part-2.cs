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
         * part-2
         * Creating a loop that counts down (and displays the count) from 01 to 0;
         * Authored by Douglas Doner
         * Date: 10/13/2014
         */
        static void Main(string[] args)
        {

            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
