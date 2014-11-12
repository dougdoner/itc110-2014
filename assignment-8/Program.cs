using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itc110_assignment_8
{
    class Program
    {
        /// <summary>
        /// This is for itc 110
        /// assignment-8
        /// 
        /// Creating a class called tip:
        /// The class will have fields for the amount the tip is based on, the percentage of the tip and the tax percent
        /// The tax percent will be a constant of .094
        /// 
        /// There will be methods in the class for calculating the tip, the tax and the total
        /// 
        /// A second class of Display will be made.
        /// the Display class gets the user's input for the amount to be tipped on, and the percent they want to tip and passes them to the Tip class.
        /// Then it retrieves the tip, tax and total amounts and displays them.
        /// 
        /// The Display class will be called from the Main() method in the Program class.
        /// </summary>
        static void Main(string[] args)
        {
            Display disp = new Display();
        }
    }
}
