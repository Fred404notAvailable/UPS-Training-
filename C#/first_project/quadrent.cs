using System;
public class quadrant
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the x coordinate: ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the y coordinate: ");
        int y = Convert.ToInt32(Console.ReadLine());
        
        if (x > 0 && y > 0)
        {
            Console.WriteLine("First Quadrant");
        }
        else if (x < 0 && y > 0)
        {
            Console.WriteLine("Second Quadrant");
        }
        else if (x < 0 && y < 0)
        {
            Console.WriteLine("Third Quadrant");
        }
        else if (x > 0 && y < 0)
        {
            Console.WriteLine("Fourth Quadrant");
        }
        else if (x == 0 && y == 0)
        {
            Console.WriteLine("At the Origin");
        }
        else if (x == 0)
        {
            Console.WriteLine("On the Y axis");
        }
        else
        {
            Console.WriteLine("On the X axis");
        }
    }
}