using System;

public class MagicArray
{
    public static bool magicno(int n)
    {
        if (n <= 0)
        {
            return false;
        }

        int temp = n;
        while (temp > 9)
        {
            int sum = 0;
            while (temp > 0)
            {
                sum += temp % 10;
                temp /= 10;
            }
            temp = sum;
        }

        return temp == 1;
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
        Console.Write("The magic numbers in the array : ");
        foreach (int i in num_array)
        {
            if (magicno(i))
            {
                Console.Write(i + " ");
                count++;
            }
        }
        Console.WriteLine();
        Console.WriteLine("The count of magic numbers in the array : " + count);
    }
}
