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
            RunCalculator(ChooseCalculator());
        }

        private static int ChooseCalculator()
        {
            // User makes their selection on whether they want to use the simple calculator or the BMI calculator
            Console.WriteLine("Would you like to use the 'Simple Calculator' or the 'BMI Calculator'?");
            Console.WriteLine("\tPress 1 for 'Simple Calculator'");
            Console.WriteLine("\tPress 2 for 'BMI Calculator'");
            Console.Write("Your option (int): ");
            int userSelection = int.Parse(Console.ReadLine());
            return userSelection;
        }

        private static void RunCalculator(int userSelection)
        {
            switch (userSelection)
            {
                case 1:
                    Console.WriteLine("You have chosen 'Simple Calculator'");
                    SimpleCalculator simpleCalc = new SimpleCalculator();
                    simpleCalc.GetInputValues(userSelection);
                    simpleCalc.RunCalculator();                    
                    break;
                case 2:
                    Console.WriteLine("You have chosen 'BMI Calculator'");
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
            Console.WriteLine("Answer = " + result);
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
        double heightInMeters = 0;
        double weightInKg = 0;

        public void RunCalculator()
        {
            double userBMI = CalculateBMI(firstNumber, secondNumber);
            DisplayBMI(userBMI);
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
    }
}
