using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace itc110_final_douglasdoner
{
    /// <summary>
    /// This is for itc 110
    /// Final 
    /// 
    /// Using a WPF application to create a simple math problem program, user clicks on a button to select the problem type.
    /// There are four problem types: Addition, subtraction, multiplication and division.
    /// When the user clicks on a problem type button, a randomly generated equation shows up in the problem box.
    /// 
    /// The user inputs an integer into the submission text box, and the solution integer is ran against the user input to check whether or not its a correct answer.
    /// 
    /// If it is a correct answer, the message box display "good answer!".
    /// If the user's input answer is incorrect, then the message box displays "Try again".
    /// 
    /// Author: Douglas Doner
    /// 
    /// Date: 12/10/2014
    /// </summary>
    public partial class MainWindow : Window
    {
        private BasicMath basic;
        int solution;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, RoutedEventArgs e)
        {
            basic = new BasicMath();
            basic.SetVals();
            solution = basic.SetAddSolution();
            labelProblem.Content = basic.SetAddProblem();
        }

        private void buttonSubtract_Click(object sender, RoutedEventArgs e)
        {
            basic = new BasicMath();
            basic.SetVals();
            solution = basic.SetSubSolution();
            labelProblem.Content = basic.SetSubProblem();
        }

        private void buttonMultiply_Click(object sender, RoutedEventArgs e)
        {
            basic = new BasicMath();
            basic.SetMultVals();
            solution = basic.SetMultSolution();
            labelProblem.Content = basic.SetMultProblem();
        }

        private void buttonDivide_Click(object sender, RoutedEventArgs e)
        {
            basic = new BasicMath();
            basic.SetMultVals();
            solution = basic.SetDivSolution();
            labelProblem.Content = basic.SetDivProblem();
        }

        private void buttonSubmit_Click(object sender, RoutedEventArgs e)
        {
            int answer = 0;
            bool goodNumber = false;
            //attempted to throw exception in box if try parse failed, but it didn't quite work out
            try
            {
                while (!goodNumber)
                {
                    goodNumber = int.TryParse(textInput.Text, out answer);
                    labelMessage.Content = "Please input a valid number";
                }
            }
            catch (Exception error)
            {
                labelMessage.Content = error.Message;
            }

            if (answer != solution)
            {
                labelMessage.Content = "Try again";
            }
            else
            {
                labelMessage.Content = "Good answer!";
            }
            
        }
    }
}
