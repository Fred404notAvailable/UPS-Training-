using System;

class BMICalculator
{
    static double CalculateBMI(double weight, double height)
    {
        return weight / Math.Pow(height, 2);
    }

    static string GetCategory(double bmi)
    {
        if (bmi < 18.5) return "Underweight";
        else if (bmi < 24.9) return "Normal weight";
        else if (bmi < 29.9) return "Overweight";
        else return "Obese";
    }

    static void Main(string[] args)
    {
        Console.WriteLine("=== BMI Calculator ===");
        Console.Write("Enter weight (kg): ");
        double weight = double.Parse(Console.ReadLine());
        Console.Write("Enter height (m): ");
        double height = double.Parse(Console.ReadLine());

        double bmi = CalculateBMI(weight, height);
        Console.WriteLine($"\nBMI = {bmi:F2}");
        Console.WriteLine($"Category: {GetCategory(bmi)}");
    }
}

// Date: 23-10-2026
