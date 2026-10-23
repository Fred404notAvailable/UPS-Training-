using System;

class RemoveVowels
{
    static string RemoveVowelsFromString(string input)
    {
        string vowels = "aeiouAEIOU";
        string result = "";

        foreach (char c in input)
        {
            if (!vowels.Contains(c))
                result += c;
        }
        return result;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("=== Remove Vowels from a String ===");
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        string output = RemoveVowelsFromString(input);

        Console.WriteLine($"\nInput  : {input}");
        Console.WriteLine($"Output : {output}");

        int vowelCount = input.Length - output.Length;
        Console.WriteLine($"Vowels removed: {vowelCount}");
    }
}

// Date: 23-10-2026
