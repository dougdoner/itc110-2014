using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itc110_midterm_douglasdoner
{
    class Program
    {
        /// <summary>
        /// This is for itc 110
        /// midterm
        /// 
        /// Creating a guessing game, where a random integer between 1 and 501 is gernetared.
        /// The user inputs an integer in that range, and if the input is higher or lower than the random number, the program will prompt the user to retry.
        /// The user has 10 attempts to correctly guess the number, and if too many incorrect numbers are entered, the game will end and the program will tell the user the correct number.
        /// The user will be asked if they wish to play again whether or not they guess correctly. If they wish to, another number will be generated.
        /// If not, the program will close.
        /// 
        /// The score for each game will be stored in an array.
        /// </summary>
        /// <param name="args"></param>

        int inputNumber;
        static void Main(string[] args)
        {
            Program p = new Program();

            //boolean variable for game loop
            bool playAnother = true;

            while (playAnother)
            {
                //generates a random number
                int randNumber = p.genRandom();

                //gets user inputs
                p.getUserInputs(randNumber);

                //running user inputted number against random number
                p.guessNumber(randNumber);

                playAnother = p.playAgain();
            }

            Console.ReadKey();
        }

        private void write(string input)
        {
            Console.WriteLine(input);
        }

        private void getUserInputs(int randomNumber)
        {
            bool goodNumber = false;
            while (!goodNumber || inputNumber <= 0 || inputNumber >= 501)
            {
                write("Please enter a number between 1 and 501.");
                goodNumber = int.TryParse(Console.ReadLine(), out inputNumber);
            }
        }

        private int genRandom()
        {
            Random randNum = new Random();
            int randReturn = randNum.Next(1, 501);
            return randReturn;
        }

        private void guessNumber(int randNum)
        {
            int count = 0;
            bool correctGuess = false;
            while (correctGuess == false && count < 10)
            {
                if (inputNumber < randNum)
                {
                    write("Your guess is too low.");
                    count++;
                    getUserInputs(randNum);
                }

                if (inputNumber > randNum)
                {
                    write("Your guess is too high.");
                    count++;
                    getUserInputs(randNum);
                }

                if (inputNumber == randNum)
                {
                    write("Godd job! you guessed correctly");
                    correctGuess = true;
                }
            }

            if (count >= 10)
            {
                write("Sorry, you had too many incorrect answers.");
                Console.WriteLine("the correct answer was {0}", randNum);
            }
        }

        private bool playAgain()
        {
            write("Would you like to play another?");
            string answer = Console.ReadLine();

            if (answer.Equals("Yes") || answer.Equals("yes") || answer.Equals("yeah"))
            {
                return true;
            }
            return false;
        }
    }
}
