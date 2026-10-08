using System;

public class Grade
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the Mark: ");
        double percent = Convert.ToDouble(Console.ReadLine());

        if (percent > 90)
        {
            Console.WriteLine("You Got A Grade");
        }
        else if (percent >= 80 && percent <= 90)
        {
            Console.WriteLine("You Got B Grade");
        }
        else if (percent >= 70 && percent < 80)
        {
            Console.WriteLine("You Got C Grade");
        }
        else if (percent >= 60 && percent < 70)
        {
            Console.WriteLine("You Got D Grade"); // Fixed duplicate C grade
        }
        else
        {
            Console.WriteLine("Sorry you failed");
        }
    }
}