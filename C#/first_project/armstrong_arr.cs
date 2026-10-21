using System;

public class ArmstrongArray
{
    public static bool armstrongno(int n)
    {
        if (n <= 0)
        {
            return false;
        }

        int count = 0;
        int countTemp = n;
        while (countTemp > 0)
        {
            count++;
            countTemp /= 10;
        }

        int temp = n;
        int sum = 0;
        while (temp > 0)
        {
            int digit = temp % 10;
            sum += (int)Math.Pow(digit, count);
            temp /= 10;
        }

        return sum == n;
    }

    public static void Main(string[] args)
    {
        Console.Write("Enter the size of the array : ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] num_array = new int[n];

        Console.WriteLine("Enter the elements of the array");
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter the element " + (i + 1) + " : ");
            num_array[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.Write("The numbers in the array : ");
        foreach (int i in num_array)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();

        int count = 0;
        Console.Write("The armstrong numbers in the array : ");
        foreach (int i in num_array)
        {
            if (armstrongno(i))
            {
                Console.Write(i + " ");
                count++;
            }
        }
        Console.WriteLine();
        Console.WriteLine("The count of armstrong numbers in the array : " + count);
    }
}
