using System;

class PowerOfNumber
{
    static double FindPower(double baseNum, double exponent)
    {
        return Math.Pow(baseNum, exponent);
    }

    static void Main(string[] args)
    {
        Console.WriteLine("=== Power of a Number ===");
        Console.Write("Enter base: ");
        double baseNum = double.Parse(Console.ReadLine());
        Console.Write("Enter exponent: ");
        double exponent = double.Parse(Console.ReadLine());

        double result = FindPower(baseNum, exponent);
        Console.WriteLine($"{baseNum}^{exponent} = {result}");
    }
}

// Date: 23-10-2026
