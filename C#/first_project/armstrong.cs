using System;

public class Armstrong
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the num");
        int num = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        int count = 0;

        int countTemp = num;
        while (countTemp > 0)
        {
            count++;
            countTemp /= 10;
        }

        int temp = num;
        while (temp > 0)
        {
            int digit = temp % 10;
            sum += (int)Math.Pow(digit, count);
            temp /= 10;
        }

        if (num > 0 && sum == num)
        {
            Console.WriteLine(num + " is an Armstrong number");
        }
        else
        {
            Console.WriteLine(num + " is not an Armstrong number");
        }
    }
}