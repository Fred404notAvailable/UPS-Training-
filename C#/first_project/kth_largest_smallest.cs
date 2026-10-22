using System;

public class KthLargestSmallest
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

        Console.Write("Enter the value of k : ");
        int k = Convert.ToInt32(Console.ReadLine());

        if (k <= 0 || k > n)
        {
            Console.WriteLine("Invalid value of k! k must be between 1 and " + n);
            return;
        }

        // Sort the array in ascending order
        int[] sorted_array = (int[])num_array.Clone();
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if (sorted_array[i] > sorted_array[j])
                {
                    int temp = sorted_array[i];
                    sorted_array[i] = sorted_array[j];
                    sorted_array[j] = temp;
                }
            }
        }

        Console.Write("Sorted array in ascending order : ");
        foreach (int i in sorted_array)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();

        Console.WriteLine("The " + k + "th smallest element is : " + sorted_array[k - 1]);
        Console.WriteLine("The " + k + "th largest element is : " + sorted_array[n - k]);
    }
}
