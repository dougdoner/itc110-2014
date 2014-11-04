using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itc110_inclass110314
{
    /// <summary>
    /// itc 110
    /// in-class
    /// fields -- class level variables that describe the class
    /// properties -- make field accessible
    /// methods -- what the class does
    /// constructors -- initializing the class
    /// 
    /// Date: 11/03/2014
    /// </summary>
    class Mileage
    {
        //constructor -- in this case it's a default constructor
        //it sets default values
        public Mileage()
        {
            Miles = 0;
            gallons = 1;
        }

        //this constructor takes arguments, so when you call the new class, you can set variables in main
        public Mileage(double miles, double gallons)
        {
            Miles = miles;
            Gallons = gallons;
        }
        //fields -- class level variables
        private double gallons;
        private double miles;

        public double Miles
        {
          get { return miles; }
          set { miles = value; }
        }

        //properties don't take arguments
        public double Gallons
        {
            set 
            {
                if (value <= 0)
                {
                    Exception ex = new Exception("Enter a valid number for gallons");
                    throw ex;
                }
                else
                {
                    gallons = value;
                }
            }

            get { return gallons; }
        }


        //public method
        public double CalculateGasMileage()
        {
            return Miles / Gallons;
        }

    }
}
