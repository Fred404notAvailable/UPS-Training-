using System;

class QuadraticRoots
{
    static void FindQuadraticRoots(double a, double b, double c)
    {
        double discriminant = Math.Pow(b, 2) - 4 * a * c;

        Console.WriteLine($"\nEquation : {a}x² + {b}x + {c} = 0");
        Console.WriteLine($"Discriminant (b²-4ac) = {discriminant}");

        if (discriminant > 0)
        {
            double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            Console.WriteLine($"Two Real Roots:");
            Console.WriteLine($"  Root 1 = {root1:F4}");
            Console.WriteLine($"  Root 2 = {root2:F4}");
        }
        else if (discriminant == 0)
        {
            double root = -b / (2 * a);
            Console.WriteLine($"One Repeated Real Root:");
            Console.WriteLine($"  Root = {root:F4}");
        }
        else
        {
            double realPart = -b / (2 * a);
            double imagPart = Math.Sqrt(Math.Abs(discriminant)) / (2 * a);
            Console.WriteLine($"Imaginary Roots (No Real Solution):");
            Console.WriteLine($"  Root 1 = {realPart:F4} + {imagPart:F4}i");
            Console.WriteLine($"  Root 2 = {realPart:F4} - {imagPart:F4}i");
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("=== Quadratic Equation Solver (ax² + bx + c = 0) ===");
        Console.Write("Enter a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter c: ");
        double c = double.Parse(Console.ReadLine());

        FindQuadraticRoots(a, b, c);
    }
}

// Date: 23-10-2026
