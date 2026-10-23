using System;

class SubstringCount
{
    static int CountOccurrences(string mainStr, string subStr)
    {
        if (string.IsNullOrEmpty(subStr))
            return 0;

        int count = 0;
        int index = 0;

        while ((index = mainStr.IndexOf(subStr, index, StringComparison.OrdinalIgnoreCase)) != -1)
        {
            count++;
            index += subStr.Length;
        }

        return count;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("=== Count Occurrences of a Substring ===");
        Console.Write("Enter the main string    : ");
        string mainStr = Console.ReadLine();
        Console.Write("Enter the substring      : ");
        string subStr = Console.ReadLine();

        int count = CountOccurrences(mainStr, subStr);

        Console.WriteLine($"\nMain String : \"{mainStr}\"");
        Console.WriteLine($"Substring   : \"{subStr}\"");
        Console.WriteLine($"Occurrences : {count}");
    }
}

// Date: 23-10-2026
