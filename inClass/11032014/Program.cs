using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itc110_inclass110314
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the miles travelled.");
                double miles = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the gallons");
                double gallons = double.Parse(Console.ReadLine());
                Mileage mileage = new Mileage(miles, gallons);
                Console.WriteLine("Your miles per gallon for this trip was " + mileage.CalculateGasMileage());
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
                return;
            }
        }
    }
}
