using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itc110_assignment7_douglasdoner
{
    class Program
    {
        /// <summary>
        /// This is for itc 110
        /// assignment-7
        /// Taking a program that calculates 41 prime noumbers in a row starting with 41.
        /// Breaking the operations into appropriate methods.
        /// The main will do nothing but clal the starting method
        /// </summary>
        static void Main(string[] args)
        {
            Program p = new Program();
            p.GetInputs();
        }

        private void GetInputs()
        {
            int number = 0;
            Console.WriteLine("Please enter an integer between 1 and 41");
            TestInts(number);
        }

        private void TestInts(int num)
        {
            bool isInt = int.TryParse(Console.ReadLine(), out num);
            if (!isInt)
            {
                Console.WriteLine("Please enter a valide integer");
                Console.ReadKey();
                return;
            }
            if (num < 1 || num > 41)
            {
                Console.WriteLine("Please enter a valid integer between 1 and 41");
                Console.ReadKey();
                return;
            }
            else
            {
                CalculateInt(num);
            }
        }

        private void CalculateInt(int num2)
        {
            int prime = num2 * num2 - num2 + 41;
            Console.WriteLine("The Prime number is {0}", prime);
            Console.ReadKey();
        }
    }
}
