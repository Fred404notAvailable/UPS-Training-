using System;

class DistanceTwoPoints
{
    static double GetDistance(double x1, double y1, double x2, double y2)
    {
        return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    }

    static void Main(string[] args)
    {
        Console.WriteLine("=== Distance Between Two Points ===");
        Console.Write("Enter x1: ");
        double x1 = double.Parse(Console.ReadLine());
        Console.Write("Enter y1: ");
        double y1 = double.Parse(Console.ReadLine());
        Console.Write("Enter x2: ");
        double x2 = double.Parse(Console.ReadLine());
        Console.Write("Enter y2: ");
        double y2 = double.Parse(Console.ReadLine());

        double dist = GetDistance(x1, y1, x2, y2);
        Console.WriteLine($"\nDistance between ({x1},{y1}) and ({x2},{y2}) = {dist:F4}");
    }
}

// Date: 23-10-2026
