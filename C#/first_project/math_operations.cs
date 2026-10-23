using System;

class MathOperations
{
    // 1. Power of a Number
    static double FindPower(double baseNum, double exponent)
    {
        return Math.Pow(baseNum, exponent);
    }

    // 2. Absolute Value Finder
    static int GetAbsolute(int num)
    {
        return Math.Abs(num);
    }

    // 3. Find Maximum and Minimum
    static void FindMaxMin(int a, int b)
    {
        Console.WriteLine($"  Max: {Math.Max(a, b)}");
        Console.WriteLine($"  Min: {Math.Min(a, b)}");
    }

    // 4. Round a Number
    static double RoundValue(double num)
    {
        return Math.Round(num);
    }

    // 5. Calculate Compound Interest
    static double CalculateCompoundInterest(double principal, double rate, int time)
    {
        return principal * Math.Pow((1 + rate / 100), time) - principal;
    }

    // 6. Calculate BMI
    static double CalculateBMI(double weight, double height)
    {
        return weight / Math.Pow(height, 2);
    }

    // 7. Find Distance Between Two Points
    static double GetDistance(double x1, double y1, double x2, double y2)
    {
        return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    }

    // 8. Temperature Conversion with Rounding
    static double ConvertTemp(double celsius)
    {
        double fahrenheit = (celsius * 9.0 / 5.0) + 32;
        return Math.Round(fahrenheit);
    }

    // 9. Random Circle Area Generator
    static void RandomCircleArea()
    {
        Random rand = new Random();
        double radius = rand.Next(1, 21); // random radius between 1 and 20
        double area = Math.PI * Math.Pow(radius, 2);
        Console.WriteLine($"  Random Radius : {radius}");
        Console.WriteLine($"  Circle Area   : {area:F4}");
    }

    // 10. Solve Quadratic Equation Roots
    static void FindQuadraticRoots(double a, double b, double c)
    {
        double discriminant = Math.Pow(b, 2) - 4 * a * c;
        if (discriminant > 0)
        {
            double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            Console.WriteLine($"  Root 1: {root1:F4}");
            Console.WriteLine($"  Root 2: {root2:F4}");
        }
        else if (discriminant == 0)
        {
            double root = -b / (2 * a);
            Console.WriteLine($"  One Real Root: {root:F4}");
        }
        else
        {
            double realPart = -b / (2 * a);
            double imagPart = Math.Sqrt(Math.Abs(discriminant)) / (2 * a);
            Console.WriteLine($"  Imaginary Roots: {realPart:F4} + {imagPart:F4}i  and  {realPart:F4} - {imagPart:F4}i");
        }
    }

    // 11. Find Logarithm (Base 10 and Base e)
    static void FindLogs(double num)
    {
        Console.WriteLine($"  Log Base 10 : {Math.Log10(num):F6}");
        Console.WriteLine($"  Log Base e  : {Math.Log(num):F6}");
    }

    // 12. Trigonometric Calculator
    static void ShowTrigValues(double angle)
    {
        Console.WriteLine($"  Sin({angle}) = {Math.Sin(angle):F6}");
        Console.WriteLine($"  Cos({angle}) = {Math.Cos(angle):F6}");
        Console.WriteLine($"  Tan({angle}) = {Math.Tan(angle):F6}");
    }

    // 13. Rounding Techniques Comparison
    static void RoundingComparison(double num)
    {
        Console.WriteLine($"  Number         : {num}");
        Console.WriteLine($"  Math.Floor()   : {Math.Floor(num)}");
        Console.WriteLine($"  Math.Ceiling() : {Math.Ceiling(num)}");
        Console.WriteLine($"  Math.Round()   : {Math.Round(num)}");
    }

    // 14. Find Exponential Growth (Population Growth)
    static double PopulationGrowth(double initial, double rate, int years)
    {
        return initial * Math.Exp(rate * years);
    }

    static void Main(string[] args)
    {
        Console.WriteLine("========================================");
        Console.WriteLine("       MATH OPERATIONS IN C#            ");
        Console.WriteLine("========================================\n");

        // 1. Power of a Number
        Console.WriteLine("1. Power of a Number");
        Console.WriteLine($"   2^10 = {FindPower(2, 10)}");

        // 2. Absolute Value
        Console.WriteLine("\n2. Absolute Value Finder");
        Console.WriteLine($"   |(-45)| = {GetAbsolute(-45)}");

        // 3. Max and Min
        Console.WriteLine("\n3. Find Maximum and Minimum (a=34, b=78)");
        FindMaxMin(34, 78);

        // 4. Round a Number
        Console.WriteLine("\n4. Round a Number");
        Console.WriteLine($"   Round(7.65) = {RoundValue(7.65)}");

        // 5. Compound Interest
        Console.WriteLine("\n5. Compound Interest");
        Console.WriteLine($"   Principal=5000, Rate=8%, Time=3 years");
        Console.WriteLine($"   Interest = {CalculateCompoundInterest(5000, 8, 3):F2}");

        // 6. BMI
        Console.WriteLine("\n6. Calculate BMI");
        Console.WriteLine($"   Weight=70kg, Height=1.75m");
        Console.WriteLine($"   BMI = {CalculateBMI(70, 1.75):F2}");

        // 7. Distance Between Two Points
        Console.WriteLine("\n7. Distance Between Two Points");
        Console.WriteLine($"   (1,2) to (4,6)");
        Console.WriteLine($"   Distance = {GetDistance(1, 2, 4, 6):F4}");

        // 8. Temperature Conversion
        Console.WriteLine("\n8. Temperature Conversion (Celsius to Fahrenheit)");
        Console.WriteLine($"   100°C = {ConvertTemp(100)}°F");

        // 9. Random Circle Area
        Console.WriteLine("\n9. Random Circle Area Generator");
        RandomCircleArea();

        // 10. Quadratic Roots
        Console.WriteLine("\n10. Quadratic Equation Roots (x^2 - 5x + 6 = 0)");
        FindQuadraticRoots(1, -5, 6);
        Console.WriteLine("    Imaginary Example (x^2 + x + 1 = 0):");
        FindQuadraticRoots(1, 1, 1);

        // 11. Logarithms
        Console.WriteLine("\n11. Logarithms of 100");
        FindLogs(100);

        // 12. Trigonometric Values
        Console.WriteLine("\n12. Trigonometric Values (angle = PI/4 radians)");
        ShowTrigValues(Math.PI / 4);

        // 13. Rounding Techniques
        Console.WriteLine("\n13. Rounding Techniques Comparison");
        RoundingComparison(4.7);

        // 14. Population Growth
        Console.WriteLine("\n14. Exponential Population Growth");
        Console.WriteLine($"    Initial=1000, Rate=0.03, Years=10");
        Console.WriteLine($"    Population = {PopulationGrowth(1000, 0.03, 10):F2}");

        Console.WriteLine("\n========================================");
        Console.WriteLine("              END OF PROGRAM            ");
        Console.WriteLine("========================================");
    }
}

// Date: 23-10-2026
