using System;

class TrigonometricCalculator
{
    static void ShowTrigValues(double angle)
    {
        Console.WriteLine($"Angle (radians) : {angle:F6}");
        Console.WriteLine($"Sin({angle:F4})      = {Math.Sin(angle):F6}");
        Console.WriteLine($"Cos({angle:F4})      = {Math.Cos(angle):F6}");
        Console.WriteLine($"Tan({angle:F4})      = {Math.Tan(angle):F6}");
    }

    static void Main(string[] args)
    {
        Console.WriteLine("=== Trigonometric Calculator ===");
        Console.WriteLine("Enter angle in degrees: ");
        double degrees = double.Parse(Console.ReadLine());

        double radians = degrees * Math.PI / 180;
        Console.WriteLine($"\nConverted to radians: {radians:F6}");
        Console.WriteLine();
        ShowTrigValues(radians);
    }
}

// Date: 23-10-2026
