using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class SimpleCalculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple Calculator\n");

            // User enters two numbers to perform calculations on
            Console.Write("Please Enter your first number (double): ");
            double firstNumber = double.Parse(Console.ReadLine());
            Console.Write("Please Enter your second number (double): ");
            double secondNumber = double.Parse(Console.ReadLine());

            // Display the user selected numbers before performing any calculations
            Console.WriteLine("\nYour numbers are:\n" + "firstNumber: " + firstNumber + "\nsecondNumber: " + secondNumber);

            // User selects the calculation method
            Console.WriteLine("\nPlease Select the calculation you wish to perform:\n 1. Add \n 2. Subtract \n 3. Multiply \n 4. Divide \n 5. Modulo \n");
            Console.Write("Please type in a number between 1 and 5 (int): ");

            int calculationMethod = int.Parse(Console.ReadLine());

            switch (calculationMethod)
            {
                case 1:
                    Console.WriteLine("You have selected '1. Add'");
                    Console.Write(firstNumber + " + " + secondNumber + " = ");
                    Console.WriteLine(firstNumber + secondNumber);
                break;
                case 2:
                    Console.WriteLine("You have selected '2. Subtract'");
                    Console.Write(firstNumber + " - " + secondNumber + " = ");
                    Console.WriteLine(firstNumber - secondNumber);
                    break;
                case 3:
                    Console.WriteLine("You have selected '3. Multiply'");
                    Console.Write(firstNumber + " * " + secondNumber + " = ");
                    Console.WriteLine(firstNumber * secondNumber);
                    break;
                case 4:
                    Console.WriteLine("You have selected '4. Divide'");
                    Console.Write(firstNumber + " / " + secondNumber + " = ");
                    Console.WriteLine(firstNumber / secondNumber);
                    break;
                case 5:
                    Console.WriteLine("You have selected '5. Modulo'");
                    Console.Write(firstNumber + " % " + secondNumber + " = ");
                    Console.WriteLine(firstNumber % secondNumber);
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
            Console.Read();
        }
    }
}