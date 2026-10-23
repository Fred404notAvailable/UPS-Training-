using System;

class CircleAreaRandom
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Random Circle Area Generator ===");

        Random rand = new Random();
        double radius = rand.Next(1, 21); // random radius between 1 and 20
        double area = Math.PI * Math.Pow(radius, 2);

        Console.WriteLine($"Random Radius  : {radius}");
        Console.WriteLine($"Circle Area    : {area:F4}");
        Console.WriteLine($"Circumference  : {2 * Math.PI * radius:F4}");
    }
}

// Date: 23-10-2026
