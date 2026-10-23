iusing System;

class PopulationGrowth
{
    static double CalculateGrowth(double initial, double rate, int years)
    {
        return initial * Math.Exp(rate * years);
    }

    static void Main(string[] args)
    {
        Console.WriteLine("=== Exponential Population Growth ===");
        Console.Write("Enter initial population: ");
        double initial = double.Parse(Console.ReadLine());
        Console.Write("Enter growth rate (e.g. 0.03 for 3%): ");
        double rate = double.Parse(Console.ReadLine());
        Console.Write("Enter number of years: ");
        int years = int.Parse(Console.ReadLine());

        double finalPop = CalculateGrowth(initial, rate, years);

        Console.WriteLine($"\nInitial Population : {initial}");
        Console.WriteLine($"Growth Rate        : {rate * 100}% per year");
        Console.WriteLine($"Years              : {years}");
        Console.WriteLine($"Final Population   : {finalPop:F2}");
        Console.WriteLine($"Growth             : {finalPop - initial:F2}");
    }
}

// Date: 23-10-2026
