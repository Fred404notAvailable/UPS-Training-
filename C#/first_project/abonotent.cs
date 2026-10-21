using System;

public class AbundantNumber
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

        if (sum > num)
        {
            Console.WriteLine("Abundant number");
        }
        else if (sum == num)
        {
            Console.WriteLine("Perfect number");
        }
        else
        {
            Console.WriteLine("Deficient number");
        }
    }
}