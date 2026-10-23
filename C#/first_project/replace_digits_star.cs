using System;

class ReplaceDigits
{
    static string ReplaceDigitWithStar(string input)
    {
        string result = "";
        foreach (char c in input)
        {
            if (char.IsDigit(c))
                result += '*';
            else
                result += c;
        }
        return result;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("=== Replace Every Digit with * ===");
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        string output = ReplaceDigitWithStar(input);
        Console.WriteLine($"\nInput  : {input}");
        Console.WriteLine($"Output : {output}");
    }
}

// Date: 23-10-2026
