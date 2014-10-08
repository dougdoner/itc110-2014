using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itc110inClass10814
{
    class Program
    {
        /* This is for itc110
         * in-class
         * Working with loops
         * Date: 10/8/2014
         */
        static void Main(string[] args)
        {
            //stores new Random constructor inside the Random variable rand
            Random rand = new Random();

            //for loop
            for (int i = 0; i < 10; i++)
            {
                //stores a value generated by the rand.Next method insdie the int number
                int number = rand.Next(1, 501);
                Console.WriteLine(number);
            }

            Console.ReadKey();

            int number2 = 3;
            for (int i = 0; i < 10; i++)
            {
                //the number2 int variable adds itself to the value of i at that stage of the loop
                number2 += i;
                Console.WriteLine(number2);
            }

            Console.ReadKey();

            Console.WriteLine("How many loops do you want to do?");
            int number3 = int.Parse(Console.ReadLine());
            for (int i = 0; i < number3; i++)
            {
                //the number2 int variable adds itself to the value of i at that stage of the loop
                number2 += i;
                Console.WriteLine(number2);
            }

            Console.ReadKey();

            //while loop

            string go = "yes";
            int counter = 0;
            //while the string variable of go has a value of "yes", the loop will keep going until the user inputs anything other than "yes"
            while (go.Equals("yes") || go.Equals("Yes"))
            {
                counter++;
                Console.WriteLine("You have done {0} loops", counter);
                Console.WriteLine("Do you want to do another loop? Type yes or no.");
                go = Console.ReadLine();
            }

            //do while
            //will evaluate condition at least once, regardless of truthiness

            do 
            {

            } while ( go.Equals("Yes") || go.Equals("yes") );
        }
    }
}