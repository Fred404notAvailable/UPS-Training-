using System;

public class Prime
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num <= 1)
        {
            Console.WriteLine(num + " is neither prime nor composite");
            return;
        }

        bool isPrime = true;
        for (int i = 2; i <= num / 2; i++)
        {
            if (num % i == 0)
            {
                isPrime = false;
                break;
            }
        }

        if (isPrime)
        {
            Console.WriteLine(num + " is a prime number");
        }
        else
        {
            Console.WriteLine(num + " is a composite number");
        }
    }
}