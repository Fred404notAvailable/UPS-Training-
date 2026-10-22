using System;

public class ArrayOrder
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

        Console.Write("The numbers in the array : ");
        foreach (int i in num_array)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();

        // Ascending order
        int[] asc_array = (int[])num_array.Clone();
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if (asc_array[i] > asc_array[j])
                {
                    int temp = asc_array[i];
                    asc_array[i] = asc_array[j];
                    asc_array[j] = temp;
                }
            }
        }

        Console.Write("The elements in ascending order : ");
        foreach (int i in asc_array)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();

        // Descending order
        int[] desc_array = (int[])num_array.Clone();
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if (desc_array[i] < desc_array[j])
                {
                    int temp = desc_array[i];
                    desc_array[i] = desc_array[j];
                    desc_array[j] = temp;
                }
            }
        }

        Console.Write("The elements in descending order : ");
        foreach (int i in desc_array)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }
}
