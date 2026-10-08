using System;
public class Calc
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the first number");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the Second number");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the your Choice");
        Console.WriteLine("1.Addition\n2.Subtraction\n3.Multiplication\n4.Division");
        int ch = Convert.ToInt32(Console.ReadLine());
        switch (ch)
        {
            case(1):
            Console.WriteLine(num1+num2);
            break;

            case(2):
            Console.WriteLine(num1-num2);
            break;

            case(3):
            Console.WriteLine(num1*num2);
            break;

            case(4):
            Console.WriteLine(num1/num2);
            break;

            default:
            Console.WriteLine("Enter a valid Choice");
            break;
        }


        
    }
}