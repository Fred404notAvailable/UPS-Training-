using System;

class LongestWord
{
    static string FindLongestWord(string sentence)
    {
        string[] words = sentence.Split(' ');
        string longest = "";

        foreach (string word in words)
        {
            // Strip punctuation
            string cleanWord = word.Trim('.', ',', '!', '?', ';', ':');
            if (cleanWord.Length > longest.Length)
                longest = cleanWord;
        }

        return longest;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("=== Find the Longest Word in a String ===");
        Console.Write("Enter a sentence: ");
        string sentence = Console.ReadLine();

        string[] words = sentence.Split(' ');
        string longest = FindLongestWord(sentence);

        Console.WriteLine($"\nSentence     : {sentence}");
        Console.WriteLine($"Total Words  : {words.Length}");
        Console.WriteLine($"Longest Word : \"{longest}\" ({longest.Length} characters)");
    }
}

// Date: 23-10-2026
