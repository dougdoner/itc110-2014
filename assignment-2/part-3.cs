using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2Part3
{
    class Program
    {
        /* This is for assignment-2
         * part 3
         * Entering a meal amount. Entering the tip percentage as a whole number 15, 20 etc. Making Tax a constant at .092. Outputting the amount, the tip (remember you will have to divide the tip percent by 100), the tax and the total.
         * Authored by Douglas Doner
         * Date: 09/29/2014
         */
        static void Main(string[] args)
        {
            double meal, total, tip;
            const double TAX = .092;

            Console.WriteLine("Enter in the meal amount");
            //parsing the string input from user, and storing as a double in meal
            meal = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter in a tip amount, as a whole number");
            
            tip = (double.Parse(Console.ReadLine())) / 100;
            Console.WriteLine("Your meal amount: ${0}", meal);
            Console.WriteLine("Your tip: {0} percent", tip * 100);
            Console.WriteLine("The tax for this meal is: {0} percent", TAX * 100);
            total = meal + (meal * tip) + (meal * TAX);
            Console.WriteLine("The total for this meal is: ${0}", total);
            Console.ReadKey();
        }
    }
}
