using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itc110inClass101314
{
    class Program
    {
        /* This is for itc 110
         * In-class
         * arrays
         * Date: 10/13/2014
         */
        static void Main(string[] args)
        {
            //an array is a variable that can store more than one value
            // all elements of an array have to be the same data-type
            string[] members = new string[4];
            members[0] = "Rebecca";
            members[1] = "George";
            members[2] = "Karen";
            members[3] = "Joe";

            //before you use an array, you must declare the size of the array by saying (string[] array = new string[int number])
            string[] colors;
            Console.WriteLine("How many colors do you want to enter");
            int number = int.Parse(Console.ReadLine());
            colors = new string[number];

            for (int i = 0; i < colors.Length; i++)
            {
                Console.WriteLine("Enter Color");
                colors[i] = Console.ReadLine();
            }

            for (int i = 0; i < colors.Length; i++)
            {
                Console.WriteLine("The color for index {0} is {1}", i, colors[i]);
            }

            //you can declear the values in curly braces after declaring the string array
            string[] dogs = new string[] { "Spaniel", "Pug", "Chihuahua", "Husky", "Yorkie" };

            bool dogCheck = false;
            int dog = 0;

            while (!dogCheck)
            {
                Console.WriteLine("Choose a number between 1 to 5");
                dog = int.Parse(Console.ReadLine());

                if (dog >= 0 && dog < 6) {
                    dogCheck = true;
                }
            }
            Console.WriteLine("Your dog is {0}", dogs[dog - 1]);
            Console.ReadKey();

            //number arrays

            int ones = 0, twos = 0, threes = 0, fours = 0;
            Random rand = new Random();
            int[] numberArray = new int[50];

            //populate the int array
            for (int i = 0; i < numberArray.Length; i++)
            {
                numberArray[i] = rand.Next(1, 5);
            }

            //foreach loop
            foreach (int i in numberArray)
            {
                if (i == 1)
                {
                    ones++;
                }
                else if (i == 2)
                {
                    twos++;
                }
                else if (i == 3)
                {
                    threes++;
                }
                else
                {
                    fours++;
                }
            }

            //Console.Write doesn't put every ouput on a new line
            Console.Write("\nOnes:\t");

            for (int i = 0; i < ones; i++)
            {
                Console.Write("*");
            }

            Console.Write("\nTwos:\t");
            for (int i = 0; i < twos; i++)
            {
                Console.Write("*");
            }

            Console.Write("\nThrees:\t");
            for (int i = 0; i < threes; i++)
            {
                Console.Write("*");
            }

            Console.Write("\nFours:\t");
            for (int i = 0; i < fours; i++)
            {
                Console.Write("*");
            }

            int[] numbersArrayTwo = new int[50];

            for (int i = 0; i < numbersArrayTwo.Length; i++)
            {
                numbersArrayTwo[i] = rand.Next(1, 1000);
            }

            int max = 0;

            foreach (int i in numbersArrayTwo)
            {
                if (i > max)
                {
                    max = i;
                }
            }

            Console.WriteLine("The max is {0}", max);

            //two-dimensional arrays
            //first value is rows, second value is columns
            string[,] books = new string[3, 2];
            books[0, 0] = "The Lord of the Rings";
            books[0, 1] = "Tolkien";
            books[1, 0] = "The Grapes of Wrath";
            books[1, 1] = "Steinbeck";
            books[2, 0] = "The Martian Cronciles";
            books[2, 1] = "Bradbury";

            Console.WriteLine("Enter an author");
            string author = Console.ReadLine();

            for (int i = 0; i < 3; i++)
            {
                if (author.Equals(books[i, 1]))
                {
                    Console.WriteLine(books[i, 0]);
                }
            }
                Console.ReadKey();
        }
    }
}
