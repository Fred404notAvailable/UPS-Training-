using System;

class CompoundInterest
{
    static double CalculateCompoundInterest(double principal, double rate, int time)
    {
        return principal * Math.Pow((1 + rate / 100), time) - principal;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("=== Compound Interest Calculator ===");
        Console.Write("Enter Principal amount: ");
        double principal = double.Parse(Console.ReadLine());
        Console.Write("Enter Rate of interest (%): ");
        double rate = double.Parse(Console.ReadLine());
        Console.Write("Enter Time (years): ");
        int time = int.Parse(Console.ReadLine());

        double interest = CalculateCompoundInterest(principal, rate, time);
        Console.WriteLine($"\nPrincipal : {principal}");
        Console.WriteLine($"Rate      : {rate}%");
        Console.WriteLine($"Time      : {time} years");
        Console.WriteLine($"Compound Interest = {interest:F2}");
        Console.WriteLine($"Total Amount      = {principal + interest:F2}");
    }
}

// Date: 23-10-2026
