using System;

class AnagramChecker
{
    static bool AreAnagrams(string str1, string str2)
    {
        // Remove spaces and convert to lowercase
        str1 = str1.Replace(" ", "").ToLower();
        str2 = str2.Replace(" ", "").ToLower();

        if (str1.Length != str2.Length)
            return false;

        int[] count = new int[26];

        foreach (char c in str1)
            count[c - 'a']++;

        foreach (char c in str2)
            count[c - 'a']--;

        foreach (int val in count)
        {
            if (val != 0)
                return false;
        }

        return true;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("=== Anagram Checker ===");
        Console.Write("Enter first string : ");
        string str1 = Console.ReadLine();
        Console.Write("Enter second string: ");
        string str2 = Console.ReadLine();

        bool result = AreAnagrams(str1, str2);

        Console.WriteLine($"\n\"{str1}\" and \"{str2}\" are: ");
        Console.WriteLine(result ? "✔ Anagrams" : "✘ Not Anagrams");
    }
}

// Date: 23-10-2026
