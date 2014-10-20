using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itc110inclass10202014
{
    class Program
    {
        /// <summary>
        /// This is for itc 110
        /// In-class
        /// Entering a shopping list into an array
        /// have a second array to store the prices
        /// and a third array to store discounts
        /// These are called parrallel arrays
        /// Use mehthods and only use main to start the program
        /// 
        /// Date: 10/20/2014
        /// </summary>
        int number;
        bool goodNumber = false;
        static void Main(string[] args)
        {
            Program p = new Program();
            p.PopulateArrays();
            p.EndProgram();
        }

        private void GetNumberOfItems()
        {
            do
            {
                Console.WriteLine("How many items do you want to enter? Must be a number");
                goodNumber = int.TryParse(Console.ReadLine(), out number);
            } while (!goodNumber);
        }

        private string[] CreateShoppingList()
        {
            string[] shoppingList = new string[number];
            return shoppingList;
        }

        private double[] CreatePriceList()
        {
            double[] priceList = new double[number];
            return priceList;
        }

        private double[] CreateDiscountList()
        {
            double[] discountList = new double[number];
            return discountList;
        }

        private void PopulateArrays()
        {
            GetNumberOfItems();
            string[] ItemList = CreateShoppingList();
            double[] prices = CreatePriceList();
            double[] discounts = CreateDiscountList();

            for (int i = 0; i < number; i++)
            {
                Console.WriteLine("Enter the item name.");
                ItemList[i] = Console.ReadLine();
                Console.WriteLine("Enter the item price");
                prices[i] = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter any discount as a decimal");
                discounts[i] = double.Parse(Console.ReadLine());
            }

            Calculate(ItemList, prices, discounts);
        }

        private void Calculate(string[] items, double[] prices, double[] discounts)
        {
            double price = 0;
            for (int i = 0; i < number; i++)
            {
                price = prices[i] - (prices[i] * discounts[i]);
                string itemString = items[i] + " " + price.ToString("C");
                Display(itemString);
            }
        }

        private void Display(string itemPrice)
        {
            Console.WriteLine(itemPrice);
        }

        private void EndProgram()
        {
            Console.WriteLine("Press any key to end.");
            Console.ReadKey();
        }
    }
}
