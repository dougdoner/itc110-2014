using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itc110_final_douglasdoner
{
    class BasicMath
    {
        Random randAdd = new Random();
        private int firstVal;
        private int secondVal;
        private string solution;

        public int FirstVal
        {
            get { return firstVal;  }
            set { firstVal = value; }
        }

        public int SecondVal
        {
            get { return secondVal; }
            set { secondVal = value; }
        }

        public string Solution 
        {
            get { return solution; }
            set { solution = value; }
        }

        //sets the solution for each set of problem, to be run against the user's input
        public int SetAddSolution()
        {
            return FirstVal + SecondVal;
        }

        public int SetSubSolution()
        {
            if (FirstVal > SecondVal)
            {
                return FirstVal - SecondVal;
            }
            else
            {
                return SecondVal - FirstVal;
            }
        }

        public int SetMultSolution()
        {
            return FirstVal * SecondVal;
        }

        public int SetDivSolution()
        {
            if (FirstVal > SecondVal)
            {
                return FirstVal / SecondVal;
            }
            else
            {
                return SecondVal / FirstVal;
            }
        }


        //formats a string that shows up in the problem label box on the form
        public string SetAddProblem() 
        {
            if (FirstVal > SecondVal) 
            {
                return string.Format("{0} + {1}", FirstVal, SecondVal);
            }
            else {
                return string.Format("{0} + {1}", SecondVal, FirstVal);
            }
        }

        public string SetSubProblem()
        {
            if (FirstVal > SecondVal)
            {
                return string.Format("{0} - {1}", FirstVal, SecondVal);
            }
            else
            {
                return string.Format("{0} - {1}", SecondVal, FirstVal);
            }
        }

        public string SetMultProblem()
        {
            return string.Format("{0} * {1}", FirstVal, SecondVal);
        }

        public string SetDivProblem()
        {
            if (FirstVal > SecondVal)
            {
                return string.Format("{0} / {1}", FirstVal, SecondVal);
            }
            else
            {
                return string.Format("{0} / {1}", SecondVal, FirstVal);
            }
        }

        //sets values for adding and subtracting
        public void SetVals()
        {
            FirstVal = randAdd.Next(1, 21);
            SecondVal = randAdd.Next(1, 21);
        }

        //sets values for multiplying and dividing, as to not give scary equations
        public void SetMultVals()
        {
            FirstVal = randAdd.Next(1, 8);
            SecondVal = randAdd.Next(1, 8);
        }
    }
}
