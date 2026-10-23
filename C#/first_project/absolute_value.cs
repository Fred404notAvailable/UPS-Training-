using System;

class AbsoluteValue
{
    static int GetAbsolute(int num)
    {
        return Math.Abs(num);
    }

    static void Main(string[] args)
    {
        Console.WriteLine("=== Absolute Value Finder ===");
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());

        Console.WriteLine($"|{num}| = {GetAbsolute(num)}");
    }
}

// Date: 23-10-2026
