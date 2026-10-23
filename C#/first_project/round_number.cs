using System;

class RoundNumber
{
    static double RoundValue(double num)
    {
        return Math.Round(num);
    }

    static void Main(string[] args)
    {
        Console.WriteLine("=== Round a Number ===");
        Console.Write("Enter a decimal number: ");
        double num = double.Parse(Console.ReadLine());

        Console.WriteLine($"Math.Round({num}) = {RoundValue(num)}");
    }
}

// Date: 23-10-2026
