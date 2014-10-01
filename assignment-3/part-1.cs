using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3Part1
{
    class Program
    {
        /* This is for assignment 3
         * part-1
         * Using the tip assignment from 3 in Assignment 2, Changing it so the user can enter a decimal or a whole number for the tip percent. So if the percent is greater than 1 divide by 100 otherwise use the decimal they provided.
         * Authored by Douglas Doner
         * Date: 10/1/2014
         */
        static void Main(string[] args)
        {
            double meal, total, tip;
            const double TAX = .092;
            Console.WriteLine("Enter in the meal amount");
            //parsing the string input from user, and storing as a double in meal
            meal = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter in a tip amount, as a whole number or as a decimal");
            tip = double.Parse(Console.ReadLine());
            if (tip >= 1)
            {
                tip = tip / 100;
            }
            Console.WriteLine("Your meal amount: ${0}", meal);
            Console.WriteLine("Your tip: {0}", tip);
            Console.WriteLine("The tax for this meal is: {0} percent", TAX * 100);
            total = meal + (meal * tip) + (meal * TAX);
            Console.WriteLine("The total for this meal is: ${0}", total);
            Console.ReadKey();
        }
    }
}
