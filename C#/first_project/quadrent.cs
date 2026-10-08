using System;
public class quadrent
{
    public static void Main(string[] args)
    {
        console.Write("Enter the x coordinate: ");
        int x = Convert.ToInt32(Console.ReadLine);
        Console.Write("Enter the y coordinate: ");
        int y = Convert.ToInt32(Console.ReadLine);
        
        if (x>0 && y > 0)
        {
            Console.WriteLine("First Quadrent");
        }
        else if (x<0 && y > 0)
        {
            Console.WriteLine("Second Quadrent");
        }else if (x<0 && y < 0)
        {
            Console.WriteLine("Third Quadrent");
        }else if (x>0 && y < 0)
        {
            Console.WriteLine("Fourth Quadrent");
        }


    }
    }