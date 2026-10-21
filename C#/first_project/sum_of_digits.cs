using System;

public class SumOfDigits
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the num");
        int num = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        int temp = Math.Abs(num);
        int count = 0;
        int prod = 1;

        if (temp == 0)
        {
            sum = 0;
            prod = 0;
            count = 1;
        }
        else
        {
            while (temp > 0)
            {
                int digit = temp % 10;
                count++;
                sum += digit;
                prod *= digit;
                temp /= 10;
            }
        }

        Console.WriteLine("The sum of digits of " + num + " is: " + sum);
        Console.WriteLine("The product of digits of " + num + " is: " + prod);
        Console.WriteLine("The count of digits of " + num + " is: " + count);
    }
}