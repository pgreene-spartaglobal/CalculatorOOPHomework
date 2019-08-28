using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculator
{
    class BMICalculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BMI Formula used from: " + "https://www.thecalculatorsite.com/articles/health/bmi-formula-for-bmi-calculations.php");
            Console.WriteLine("\nBMI Calculator\n");
			
			// User inputs height and weight
            Console.Write("Please enter your height in meters(m) (e.g. 1.8) (double): ");
            double heightInMeters = double.Parse(Console.ReadLine());
            Console.Write("Please enter your weight in kilograms(kg) (e.g. 75) (double): ");
            double weightInKg = double.Parse(Console.ReadLine());
			
			// Calculate BMI
            double BMI = weightInKg / (heightInMeters * heightInMeters);
			
			// Display users BMI
            Console.WriteLine("\nBMI = weight (kg) / [height (m)]^2 ");
            Console.WriteLine("\nYour BMI = " + BMI + "\n");
            
			// Declare variable to store the users BMI category
            string BMICategory = "";
			
			// Display all BMI categories
            Console.WriteLine("     BMI             |       BMI Category");
            Console.WriteLine("Less than 15         | Very severely underweight");
            Console.WriteLine("Between 15 and 16    | Severely underweight");
            Console.WriteLine("Between 16 and 18.5  | Underweight ");
            Console.WriteLine("Between 18.5 and 25  | Normal (healthy weight) ");
            Console.WriteLine("Between 25 and 30    | Overweight ");
            Console.WriteLine("Between 30 and 35    | Moderately obese ");
            Console.WriteLine("Between 35 and 40    | Severely obese ");
            Console.WriteLine("Over 40              | Very severely obese ");
			
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
			
			//Display the users BMI category
            Console.Write("\nYour BMI category: ");
            Console.WriteLine(BMICategory);
            Console.Read();
        }
    }
}
