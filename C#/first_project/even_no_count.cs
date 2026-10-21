using System;

public class EvenNoCount
{
    public static bool evenno(int n)
    {
        return n % 2 == 0;
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
        Console.Write("The even numbers in the array : ");
        foreach (int i in num_array)
        {
            if (evenno(i))
            {
                Console.Write(i + " ");
                count++;
            }
        }
        Console.WriteLine();
        Console.WriteLine("The count of even numbers in the array : " + count);
    }
}