using System;

public class CountVowelsConsonants
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine() ?? "";

        int vowels = 0;
        int consonants = 0;

        foreach (char ch in input)
        {
            if (char.IsLetter(ch))
            {
                char lower = char.ToLower(ch);
                if (lower == 'a' || lower == 'e' || lower == 'i' || lower == 'o' || lower == 'u')
                {
                    vowels++;
                }
                else
                {
                    consonants++;
                }
            }
        }

        Console.WriteLine($"Vowels = {vowels}, Consonants = {consonants}");
    }
}
