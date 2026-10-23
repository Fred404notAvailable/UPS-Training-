using System;

class TemperatureConversion
{
    static double ConvertTemp(double celsius)
    {
        double fahrenheit = (celsius * 9.0 / 5.0) + 32;
        return Math.Round(fahrenheit);
    }

    static void Main(string[] args)
    {
        Console.WriteLine("=== Temperature Conversion (Celsius to Fahrenheit) ===");
        Console.Write("Enter temperature in Celsius: ");
        double celsius = double.Parse(Console.ReadLine());

        double fahrenheit = ConvertTemp(celsius);
        Console.WriteLine($"{celsius}°C = {fahrenheit}°F");
    }
}

// Date: 23-10-2026
