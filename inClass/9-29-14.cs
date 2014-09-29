using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberExample
{
    /* Numbers example
     * Authored by Douglas Doner
     * Date: 09/29/2014
     */
    class Program
    {
        static void Main(string[] args)
        {
            //can declare multiple variables of the same data type on one line
            int number, numberb, numberc;
            double number2;

            //asks user to input an integer, then assigns variable number to the parsed Console.ReadLine
            Console.WriteLine("Enter an integer");
            number = int.Parse(Console.ReadLine());
            //does the same operation as int.Parse, but can be used to convert to different data types
                //number = Convert.ToInt32(number);

            Console.WriteLine("Enter another integer");
            numberb = int.Parse(Console.ReadLine());

            //assigns answers to equations to variable numberc
            numberc = number + numberb;
            Console.WriteLine("{0} + {1} = {2}", number, numberb, numberc);
            numberc = number - numberb;
            Console.WriteLine("{0} - {1} = {2}", number, numberb, numberc);
            numberc = number * numberb;
            Console.WriteLine("{0} * {1} = {2}", number, numberb, numberc);
            numberc = number / numberb;
            Console.WriteLine("{0} / {1} = {2}", number, numberb, numberc);
            // '%' is modulus symbol, used for remainders
            numberc = number % numberb;
            Console.WriteLine("{0} % {1} = {2}", number, numberb, numberc);
            Console.ReadKey();
            Console.Clear();

            //completing this operation will still return a whole number
            number2 = number / numberb;

            //the parentheses and (double) next to the variable is called casting. casting causes the variable to change to the cast, in this case double
            //if one side of the operation is a double, the whole equation is a double
            number2 = (double)number / numberb;
            Console.WriteLine("{0} / {1} = {2}", number, numberb, number2);
            Console.ReadKey();

            //a double can store an int, but an int cannot store a double

            //there is a built-in Math library for complex equations
            Console.WriteLine(Math.Sqrt(number2));
            Console.ReadKey();

            //assigns a double to double number2, using double.Parse()
            Console.Clear();
            Console.WriteLine("Enter a double");
            number2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Your double is {0}", number2);
            Console.ReadKey();
        }
    }
}
