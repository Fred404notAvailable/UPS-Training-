using System;

public class Perfect
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        int sum = 0;

        for (int i = 1; i < num; i++)
        {
            if (num % i == 0)
            {
                sum += i;
            }
        }

        if (num > 0 && sum == num)
        {
            Console.WriteLine("It is a perfect number");
        }
        else
        {
            Console.WriteLine("It is not a perfect number");
        }
    }
}