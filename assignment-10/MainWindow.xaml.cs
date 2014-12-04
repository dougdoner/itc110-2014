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
using System.IO;

namespace itc110_douglasdoner_assignment_10
{
    /// <summary>
    /// This is for itc 110
    /// Assignment-10
    /// Using the tip class from assignment-9, and the file write and read methods, creating a form for calculating the tip for meals.
    /// Radio buttons are used to input pre-determined tip percentages, or the user can input a custom tip percentage in a text box
    /// 
    /// Simple form validation is implemented, a boolean value of true is returned if the content of the meal amount text box is empty.
    /// 
    /// Date: 12/03/2014
    /// 
    /// Author: Douglas Doner
    /// </summary>
    public partial class MainWindow : Window
    {
        private Tip tips;
        private WriteToFile write;
        public MainWindow()
        {
            InitializeComponent();
        }

        private bool checkTextContent()
        {
            if (textMealAmount.Text == "")
            {
                labelErrorMessage.Content = "Please enter in a meal amount";
                return true;
            }
            labelErrorMessage.Content = "";
            return false;
        }

        private void ButtonCalc_Click_1(object sender, RoutedEventArgs e)
        {
            bool contentChecker = checkTextContent();
            if (contentChecker)
            {
                return;
            }
            tips = new Tip();
            double goodAmount;
            bool goodMeal = double.TryParse(textMealAmount.Text, out goodAmount);
            tips.Amount = goodAmount;
            tipClicker();

            labelTipTotal.Content = tips.CalculateTip().ToString("C");
            labelTaxTotal.Content = tips.CalculateTax().ToString("C");
            labelMealTotal.Content = tips.CalculateTotal().ToString("C");
        }

        private void tipClicker()
        {
            if (RadioPercent5.IsChecked == true)
            {
                tips.TipPercentage = double.Parse(RadioPercent5.Content.ToString());
            }
            else if (RadioPercent10.IsChecked == true)
            {
                tips.TipPercentage = double.Parse(RadioPercent10.Content.ToString());
            }
            else if (RadioPercent15.IsChecked == true)
            {
                tips.TipPercentage = double.Parse(RadioPercent15.Content.ToString());
            }
            else if (RadioPercent20.IsChecked == true)
            {
                tips.TipPercentage = double.Parse(RadioPercent20.Content.ToString());
            }
            else if (RadioPercentOther.IsChecked == true)
            {
                tips.TipPercentage = double.Parse(textCustomPercent.Text);
            }
        }

        private void ButtonWrite_Click(object sender, RoutedEventArgs e)
        {
            WriteTipsToFile(labelTipTotal.Content.ToString());
            WriteTipsToFile(labelTaxTotal.Content.ToString());
            WriteTipsToFile(labelMealTotal.Content.ToString());
        }

        private void WriteTipsToFile(string lineToWrite)    
        {
            WriteToFile writer = new WriteToFile(@"C:\Users\me\Desktop\test-file.txt");
            writer.AddLines(lineToWrite);
            writer.closeCurrentFile();
        }

        private void ButtonRead_Click(object sender, RoutedEventArgs e)
        {
            labelReadFile.Content = ReturnTheFile();
        }

        private string ReturnTheFile()
        {
            string lines = null;
            try
            {
                fileReader = new StreamReader(@"C:\Users\me\Desktop\test-file.txt");
                lines = fileReader.ReadToEnd();
            }
            catch (FileNotFoundException fileNotFound)
            {
                throw fileNotFound;
            }
            catch (Exception except)
            {
                throw except;
            }
            return lines;
        }

        public StreamReader fileReader { get; set; }
    }
}
