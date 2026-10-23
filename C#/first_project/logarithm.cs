using System;

class Logarithm
{
    static void FindLogs(double num)
    {
        Console.WriteLine($"Log Base 10  : {Math.Log10(num):F6}");
        Console.WriteLine($"Log Base e   : {Math.Log(num):F6}");
    }

    static void Main(string[] args)
    {
        Console.WriteLine("=== Logarithm Calculator ===");
        Console.Write("Enter a positive number: ");
        double num = double.Parse(Console.ReadLine());

        if (num <= 0)
        {
            Console.WriteLine("Error: Logarithm is undefined for zero or negative numbers.");
            return;
        }

        FindLogs(num);
    }
}

// Date: 23-10-2026
