using System;

class MaxMin
{
    static void FindMaxMin(int a, int b)
    {
        Console.WriteLine($"Maximum : {Math.Max(a, b)}");
        Console.WriteLine($"Minimum : {Math.Min(a, b)}");
    }

    static void Main(string[] args)
    {
        Console.WriteLine("=== Find Maximum and Minimum ===");
        Console.Write("Enter first number (a): ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter second number (b): ");
        int b = int.Parse(Console.ReadLine());

        FindMaxMin(a, b);
    }
}

// Date: 23-10-2026
