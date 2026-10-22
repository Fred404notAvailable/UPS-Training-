using System;
using System.Text;

public class RemoveDigits
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine() ?? "";

        StringBuilder result = new StringBuilder();
        foreach (char ch in input)
        {
            if (!char.IsDigit(ch))
            {
                result.Append(ch);
            }
        }

        Console.WriteLine("Output: " + result.ToString());
    }
}
