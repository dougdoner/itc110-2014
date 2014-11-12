using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itc110_assignment_8
{
    class Display
    {
        //declaring the Tip class
        private Tip tips;
        public Display()
        {
            tips = new Tip();
            TipInputs();
        }

        private void TipInputs()
        {
            try
            {
                Console.WriteLine("Enter in a meal amount.");
                tips.Amount = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter a tip percentage.");
                tips.TipPercentage = double.Parse(Console.ReadLine());

                DisplayTip();
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
                Console.ReadKey();
            }
        }

        private void DisplayTip()
        {
            Console.WriteLine("Your tip for this meal will be $" + tips.CalculateTip());
            Console.WriteLine("The tax for this meal is: $" + tips.CalculateTax());
            Console.WriteLine("The total for your meal with tax and tip included is: " + tips.CalculateTotal());
            Console.ReadKey();
        }
    }
}
