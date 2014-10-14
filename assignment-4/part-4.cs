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
        * part-4
        * Creating a a do loop that runs until a user enters "Stop"
        * Authored by Douglas Doner
        * Date: 10/13/2014
        */
        static void Main(string[] args)
        {
            string loop = "go";

            do 
            {
                Console.WriteLine("Type \"stop\" if you want to stop the loop");
                loop = Console.ReadLine();
            } while (loop != "Stop" );
        }
    }
}
