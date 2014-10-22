using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itc110assignment_5
{
    class Program
    {
        /// <summary>
        /// This is for assignment-5
        /// Part 2
        /// Creating an array of strings. Placing about 10 of your favorite quotes in the array. Using a random number generator to randomly select and display one of the quotes from the array every time you use the program
        /// Authored by Douglas Doner
        /// Date: 10/22/2014
        /// </summary>
        static void Main(string[] args)
        {
            Random rand = new Random();
            string[] quotes = new string[]
            {
              "\"Frankly, my dear, I don't give a damn\" - Clark Gable",
              "\"Do or do not, there is no try\" - Yoda",
              "\"Only a Sith deals in absoloutes.\" - Obi Wan Kenobi",
              "\"What is your major malfunction?\" - R. Lee Ermey",
              "\"Science is much more than a body of knowledge. It is a way of thinking. This is central to its success. Science invites us to let the facts in, even when they don’t conform to our preconceptions.\" - Carl Sagan",
              "\"Who let the dogs out.\" - Baha men",
              "\"Pearls don’t lie on the seashore. If you want one, you must dive for it.\" - Chines Proverb",
              "\"A ship in harbor is safe, but that is not what ships are built for. \" - John A. Shedd",
              "\"Wise men speak because they have something to say; Fools because they have to say something.\" - Plato",
              "\"Never to suffer would never to have been blessed.\" - Edgar Allen Poe"
            };

            Console.WriteLine("{0}", quotes[rand.Next(1, quotes.Length)]);
            Console.ReadKey();
        }
    }
}
