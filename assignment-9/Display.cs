using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itc110_assignment9
{
    class Display
    {
        //declaring the Tip class
        private Tip tips;
        private WriteToFile writer;
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
            string tipLineOne = "Your tip for this meal will be $" + tips.CalculateTip();
            string tipLineTwo = "The tax for this meal is: $" + tips.CalculateTax();
            string tipLineThree = "The total for your meal with tax and tip included is: " + tips.CalculateTotal();
            Console.WriteLine(tipLineOne);
            Console.WriteLine(tipLineTwo);
            Console.WriteLine(tipLineThree);
            WriteTipsToFile(tipLineOne);
            WriteTipsToFile(tipLineTwo);
            WriteTipsToFile(tipLineThree);
            Console.ReadKey();
        }

        private void WriteTipsToFile(string lineToWrite)
        {
            WriteToFile writer = new WriteToFile(@"C:\Users\me\Desktop\test-file.txt");
            writer.AddLines(lineToWrite);
            writer.closeCurrentFile();
        }
    }
}

