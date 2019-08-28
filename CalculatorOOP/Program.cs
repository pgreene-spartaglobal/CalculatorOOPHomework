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
            // User selects which calculator they want to use
            switch (ChooseCalculator())
            {
                case 1:
                    Console.WriteLine("You have chosen 'Simple Calculator'");
                    break;
                case 2:
                    Console.WriteLine("You have chosen 'BMI Calculator'");
                    break;
                default:
                    break;
            }
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
    }

    class SimpleCalculator
    {

    }

    class BMICalculator
    {

    }
}
