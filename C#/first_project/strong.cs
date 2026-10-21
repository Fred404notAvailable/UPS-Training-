using System;

public class Strong
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the num");
        int num = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        int temp = num;
        int count = 0;
        int prod = 1;

        while (temp > 0)
        {
            int digit = temp % 10;
            for (int i = 1; i <= digit; i++)
            {
                prod *= i;
            }
            sum += prod;
            count++;
            temp /= 10;
            prod = 1;
        }

        if (num > 0 && sum == num)
        {
            Console.WriteLine(num + " is a Strong number");
        }
        else
        {
            Console.WriteLine(num + " is not a Strong number");
        }
    }
}