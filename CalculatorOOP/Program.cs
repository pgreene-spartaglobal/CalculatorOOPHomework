using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            // User runs the calculator they want to use
            int chosenCalculator = ChooseCalculator();

            // If the user chooses 3 then they wish to exit the program otherwise keep running calculators
            while (chosenCalculator != 3)
            {
                CreateCalculator(chosenCalculator);
                chosenCalculator = ChooseCalculator();
                Console.WriteLine("");
            }

            // End of program
            Console.Read();
        }

        private static int ChooseCalculator()
        {
            // User makes their selection on whether they want to use the simple calculator or the BMI calculator
            Console.WriteLine("Would you like to use the 'Simple Calculator' or the 'BMI Calculator' or Exit?");
            Console.WriteLine("\tPress 1 for 'Simple Calculator'");
            Console.WriteLine("\tPress 2 for 'BMI Calculator'");
            Console.WriteLine("\tPress 3 to Exit");
            Console.Write("Your option (int): ");
            int userSelection = int.Parse(Console.ReadLine());
            return userSelection;
        }

        // Create and run the calculator the user wanted
        private static void CreateCalculator(int userSelection)
        {
            switch (userSelection)
            {
                case 1:
                    Console.WriteLine("\nYou have chosen 'Simple Calculator'");
                    SimpleCalculator simpleCalc = new SimpleCalculator();
                    simpleCalc.GetInputValues(userSelection);
                    simpleCalc.RunCalculator();                    
                    break;
                case 2:
                    Console.WriteLine("/nYou have chosen 'BMI Calculator'");
                    BMICalculator bmiCalc = new BMICalculator();
                    bmiCalc.GetInputValues(userSelection);
                    bmiCalc.RunCalculator();
                    break;
                default:
                    break;
            }
        }
    }
    class Calculator
    {        
        public double firstNumber = 0;
        public double secondNumber = 0;

        // Read the inputs for the calculator
        public void GetInputValues(int userSelection)
        {
            switch (userSelection)
            {
                case 1:
                    Console.Write("Please Enter your first number (double): ");
                    firstNumber = double.Parse(Console.ReadLine());
                    Console.Write("Please Enter your second number (double): ");
                    secondNumber = double.Parse(Console.ReadLine());
                    break;
                case 2:
                    Console.Write("Please enter your height in meters(m) (e.g. 1.8) (double): ");
                    firstNumber = double.Parse(Console.ReadLine());
                    Console.Write("Please enter your weight in kilograms(kg) (e.g. 75) (double): ");
                    secondNumber = double.Parse(Console.ReadLine());
                    break;
                default:
                    break;
            }
        }
    }
    class SimpleCalculator : Calculator
    {
        public void RunCalculator()
        {
            switch (SelectOperation())
            {
                case 1:
                    DisplayResult(Add());
                    break;
                case 2:
                    DisplayResult(Subtract());
                    break;
                case 3:
                    DisplayResult(Multiply());
                    break;
                case 4:
                    DisplayResult(Divide());
                    break;
                default:
                    break;
            }
            
        }

        private int SelectOperation()
        {
            // User selects the calculation method
            Console.WriteLine("\nPlease Select the calculation you wish to perform:\n 1. Add \n 2. Subtract \n 3. Multiply \n 4. Divide\n");
            Console.Write("Enter option (int): ");

            return int.Parse(Console.ReadLine());
        }

        private void DisplayResult(double result)
        {
            Console.WriteLine("Answer = " + result + "\n");
        }

        private double Add()
        {
            return firstNumber + secondNumber;
        }
        private double Subtract()
        {
            return firstNumber - secondNumber;
        }
        private double Multiply()
        {
            return firstNumber * secondNumber;
        }
        private double Divide()
        {
            return firstNumber / secondNumber;
        }
    }
    class BMICalculator : Calculator
    {
        public void RunCalculator()
        {
            // Calculate and display users BMI
            double userBMI = CalculateBMI(firstNumber, secondNumber);
            DisplayBMI(userBMI);

            DisplayAllBMICategories();

            // Calculate and display BMI category for user
            string userBMICategory = CalculateBMICategory(userBMI);
            DisplayUserBMICategory(userBMICategory);

            Console.WriteLine("");
        }

        private double CalculateBMI(double heightInMeters, double weightInKg)
        {
            return weightInKg / (heightInMeters * heightInMeters);
        }
        private void DisplayBMI(double BMI)
        {
            // Display users BMI
            Console.WriteLine("\nBMI = weight (kg) / [height (m)]^2 ");
            Console.WriteLine("\nYour BMI = " + BMI + "\n");
        }

        private void DisplayAllBMICategories()
        {
            // Display all BMI categories
            Console.WriteLine("     BMI             |       BMI Category");
            Console.WriteLine("Less than 15         | Very severely underweight");
            Console.WriteLine("Between 15 and 16    | Severely underweight");
            Console.WriteLine("Between 16 and 18.5  | Underweight ");
            Console.WriteLine("Between 18.5 and 25  | Normal (healthy weight) ");
            Console.WriteLine("Between 25 and 30    | Overweight ");
            Console.WriteLine("Between 30 and 35    | Moderately obese ");
            Console.WriteLine("Between 35 and 40    | Severely obese ");
            Console.WriteLine("Over 40              | Very severely obese\n");
        }
        private string CalculateBMICategory(double BMI)
        {
            // Declare variable to store the users BMI category
            string BMICategory = "";

            // Determine the users BMI category
            if (BMI < 15) { BMICategory = "Very severely underweight"; }
            else if (BMI >= 15 && BMI < 16) { BMICategory = "Severely underweight"; }
            else if (BMI >= 16 && BMI < 18.5) { BMICategory = "Underweight"; }
            else if (BMI >= 18.5 && BMI < 25) { BMICategory = "Normal (healthy weight)"; }
            else if (BMI >= 25 && BMI < 30) { BMICategory = "Overweight"; }
            else if (BMI >= 30 && BMI < 35) { BMICategory = "Moderately obese"; }
            else if (BMI >= 35 && BMI <= 40) { BMICategory = "Severely obese"; }
            else if (BMI > 40) { BMICategory = "Very severely obese"; }
            else BMICategory = "Invalid";

            return BMICategory;
        }

        private void DisplayUserBMICategory(string userBMICategory)
        {
            Console.WriteLine("Your BMI Category is: " + userBMICategory);
        }
    }
}
