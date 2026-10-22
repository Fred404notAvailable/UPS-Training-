using System;

public class ReverseArray
{
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

        Console.Write("The original array : ");
        foreach (int i in num_array)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();

        int[] rev_array = new int[n];
        for (int i = 0; i < n; i++)
        {
            rev_array[i] = num_array[n - 1 - i];
        }

        Console.Write("The reversed array : ");
        foreach (int i in rev_array)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }
}
