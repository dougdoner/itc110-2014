using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itc110_assignment6_douglasdoner
{
    class Program
    {
        /// <summary>
        /// This is for assignment-6
        /// Creating a program that calculates a grade point average
        /// 
        /// This program has an input method that asks the user how many grades they want to enter. Two arrays of that size will be created
        /// One array for grades, and one for the number of credits
        /// It will loop through the arrays, prompting the users to enter the grades and credits for each course (Both arrays will be looped through in the same loop to keep the index aligned).
        /// Both arrays will be passed as parameters to a second method that does the calculations
        /// 
        /// Authored by Douglas Doner
        /// Date: 10/27/2014
        /// </summary>

        int gradeNumber;
        bool goodNumber = false;
        static void Main(string[] args)
        {

            Program p = new Program();

            p.FillGrades();
            p.EndProgram();
        }

        private void GetGradeNumbers()
        {
            //Tests for proper data type in user input, and Console.WriteLine if goodNumber returns false
            while (!goodNumber)
            {
                Console.WriteLine("How many grades would you like to input?");
                goodNumber = int.TryParse(Console.ReadLine(), out gradeNumber);
            }
        }

        private double[] CreateArray()
        {
            double[] creditsArray = new double[gradeNumber];
            return creditsArray;
        }

        private void FillGrades()
        {
            //created a method for creating multiple arrays
            GetGradeNumbers();
            double[] currentGrades = CreateArray();
            double[] currentCredits = CreateArray();

            for (int i = 0; i < gradeNumber; i++) 
            {
                //attempted to move the task of Assigning values into its own method, but had issues with testing for correct data types and passing values back to the array.
                do
                {
                    Console.WriteLine("Enter a grade for this class");
                    goodNumber = double.TryParse(Console.ReadLine(), out currentGrades[i]);
                } while (!goodNumber);

                do
                {
                    Console.WriteLine("Enter the credits for this class");
                    goodNumber = double.TryParse(Console.ReadLine(), out currentCredits[i]);
                } while (!goodNumber);
            }

            CalculateGrades(currentGrades, currentCredits);
            
        }

        //calculates the weight of each class, as well adds the weights and credit totals to a variable, cumulatively.
        //also calculates the weighted average
        private void CalculateGrades(double[] grades, double[] credits)
        {
            double totalCredit = 0;
            double totalWeights = 0;
            for (int i = 0; i < gradeNumber; i++)
            {
                double weight = grades[i] * credits[i];
                string weightedString = "Grade: " + grades[i] + " Credits: " + credits[i] + " Class weight: " + weight;

                Display(weightedString);
                totalCredit += credits[i];
                totalWeights += weight;
            }
            double weightedAverage = totalWeights / totalCredit;
            string totalString = "total credits: " + totalCredit + " total weight: " + totalWeights;
            string averageWeight = "Weighted Average: " + weightedAverage;

            Display(totalString);
            Display(averageWeight);
        }

        private void Display(string displayString)
        {
            Console.WriteLine(displayString);
        }

        private void EndProgram()
        {
            Console.WriteLine("Press any key to end");
            Console.ReadKey();
        }

    }
}
