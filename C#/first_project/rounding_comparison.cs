using System;

class RoundingComparison
{
    static void ShowRoundingComparison(double num)
    {
        Console.WriteLine($"\nNumber         : {num}");
        Console.WriteLine($"Math.Floor()   : {Math.Floor(num)}   (rounds DOWN to nearest integer)");
        Console.WriteLine($"Math.Ceiling() : {Math.Ceiling(num)}   (rounds UP to nearest integer)");
        Console.WriteLine($"Math.Round()   : {Math.Round(num)}   (rounds to nearest integer)");
    }

    static void Main(string[] args)
    {
        Console.WriteLine("=== Rounding Techniques Comparison ===");
        Console.Write("Enter a decimal number: ");
        double num = double.Parse(Console.ReadLine());

        ShowRoundingComparison(num);

        // Show with a negative number too
        Console.WriteLine($"\n--- Also showing for negative ({-num}) ---");
        ShowRoundingComparison(-num);
    }
}

// Date: 23-10-2026
