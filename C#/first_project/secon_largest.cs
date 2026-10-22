using System;

public class SecondLargest
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the size of the array : ");
        int n = Convert.ToInt32(Console.ReadLine());

        if (n < 2)
        {
            Console.WriteLine("Array must have at least 2 elements to find the second largest element.");
            return;
        }

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

        // Find distinct second smallest
        int secondSmallest = sorted_array[0];
        bool hasSecondSmallest = false;
        for (int i = 1; i < n; i++)
        {
            if (sorted_array[i] != sorted_array[0])
            {
                secondSmallest = sorted_array[i];
                hasSecondSmallest = true;
                break;
            }
        }

        // Find distinct second largest
        int secondLargest = sorted_array[n - 1];
        bool hasSecondLargest = false;
        for (int i = n - 2; i >= 0; i--)
        {
            if (sorted_array[i] != sorted_array[n - 1])
            {
                secondLargest = sorted_array[i];
                hasSecondLargest = true;
                break;
            }
        }

        if (hasSecondSmallest)
        {
            Console.WriteLine("The second smallest element is : " + secondSmallest);
        }
        else
        {
            Console.WriteLine("There is no distinct second smallest element (all elements are equal).");
        }

        if (hasSecondLargest)
        {
            Console.WriteLine("The second largest element is : " + secondLargest);
        }
        else
        {
            Console.WriteLine("There is no distinct second largest element (all elements are equal).");
        }
    }
}
