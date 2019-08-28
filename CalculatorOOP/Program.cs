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
                    
                    
                    break;
                case 2:
                    Console.WriteLine("You have chosen 'BMI Calculator'");
                    BMICalculator bmiCalc = new BMICalculator();
                    bmiCalc.GetInputValues(userSelection);
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
        // Could make RunCalculator a virtual method in the base class to be overriden in the child class
        public void RunCalculator()
        {
            SelectOperation();
        }

        public int SelectOperation()
        {
            return 0;
        }

        public double Add()
        {
            return 0;
        }
        public double Subtract()
        {
            return 0;
        }
        public double Multiply()
        {
            return 0;
        }
        public double Divide()
        {
            return 0;
        }
    }

    class BMICalculator : Calculator
    {
        public void RunCalculator()
        {

        }
    }
}
