using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace itc110_douglasdoner_assignment_10
{
    class Tip
    {
        //value fields
        private const double tax = 0.094;
        private double amount;
        private double tipPercentage;
        //returns value and sets value for private double amount
        public double Amount
        {
            get { return amount; }
            set { amount = value; }
        }
        public double TipPercentage
        {
            get { return tipPercentage; }
            set
            {
                if (value < 1)
                {
                    tipPercentage = value;
                }
                else
                {
                    tipPercentage = value / 100;
                }
            }
        }
        //public class methods
        //returns the tip as a double
        public double CalculateTip()
        {
            return Amount * TipPercentage;
        }
        //returns the tax as a double
        public double CalculateTax()
        {
            return Amount * tax;
        }
        //returns a value, using the calculate tax and tip methods to create a total
        public double CalculateTotal()
        {
            return Amount + CalculateTip() + CalculateTax();
        }
    }
}
