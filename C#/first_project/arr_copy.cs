using System;

public class ArrayCopy
{
    public static bool aresimilar(int[] arr1, int[] arr2)
    {
        if (arr1.Length != arr2.Length)
        {
            return false;
        }

        for (int i = 0; i < arr1.Length; i++)
        {
            if (arr1[i] != arr2[i])
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

        Console.Write("The original array elements : ");
        foreach (int i in num_array)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();

        // Copy elements from num_array to copied_array
        int[] copied_array = new int[n];
        for (int i = 0; i < n; i++)
        {
            copied_array[i] = num_array[i];
        }

        Console.Write("The copied array elements   : ");
        foreach (int i in copied_array)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();

        // Check whether both arrays are similar
        if (aresimilar(num_array, copied_array))
        {
            Console.WriteLine("Both arrays are similar (identical).");
        }
        else
        {
            Console.WriteLine("Both arrays are not similar.");
        }
    }
}
