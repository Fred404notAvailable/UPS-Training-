using System;

class AutomorphicNumber
{
    static bool IsAutomorphic(int num)
    {
        long square = (long)num * num;
        string numStr = num.ToString();
        string squareStr = square.ToString();

        // Check if square ends with the number itself
        return squareStr.EndsWith(numStr);
    }

    static void Main(string[] args)
    {
        Console.WriteLine("=== Automorphic Number Checker ===");
        Console.WriteLine("(A number whose square ends with the number itself)");
        Console.Write("\nEnter a number: ");
        int num = int.Parse(Console.ReadLine());

        long square = (long)num * num;
        bool result = IsAutomorphic(num);

        Console.WriteLine($"\nNumber  : {num}");
        Console.WriteLine($"Square  : {square}");
        Console.WriteLine($"Ends with \"{num}\" : {(result ? "Yes" : "No")}");
        Console.WriteLine(result
            ? $"✔ {num} is an Automorphic Number!"
            : $"✘ {num} is NOT an Automorphic Number.");

        // Bonus: show all automorphic numbers up to 1000
        Console.WriteLine("\n--- Automorphic Numbers from 1 to 1000 ---");
        for (int i = 1; i <= 1000; i++)
        {
            if (IsAutomorphic(i))
                Console.Write($"{i}  ");
        }
        Console.WriteLine();
    }
}

// Date: 23-10-2026
