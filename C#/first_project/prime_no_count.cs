using System;

public class PrimeNoCount
{
    public static bool primeno(int n)
    {
        if (n <= 1)
        {
            return false;
        }
        if (n == 2)
        {
            return true;
        }
        if (n % 2 == 0)
        {
            return false;
        }

        for (int i = 3; i <= Math.Sqrt(n); i += 2)
        {
            if (n % i == 0)
            {
                return false;
            }
        }
        return true;
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
        Console.Write("The prime numbers in the array : ");
        foreach (int i in num_array)
        {
            if (primeno(i))
            {
                Console.Write(i + " ");
                count++;
            }
        }
        Console.WriteLine();
        Console.WriteLine("The count of prime numbers in the array : " + count);
    }
}
