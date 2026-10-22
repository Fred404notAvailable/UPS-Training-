using System;

public class FrequencyArray
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

        bool[] visited = new bool[n];

        Console.WriteLine("The frequency of each element in the array : ");
        for (int i = 0; i < n; i++)
        {
            if (visited[i])
            {
                continue;
            }

            int count = 1;
            for (int j = i + 1; j < n; j++)
            {
                if (num_array[i] == num_array[j])
                {
                    visited[j] = true;
                    count++;
                }
            }

            Console.WriteLine("Element " + num_array[i] + " occurs " + count + " time(s)");
        }
    }
}
