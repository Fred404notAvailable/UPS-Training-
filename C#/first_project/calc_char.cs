using System;
public class Calci
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the first number");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the Second number");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the your Choice");
        Console.WriteLine("A.Addition\nB.Subtraction\nC.Multiplication\nD.Division");
        String ch = Console.ReadLine();
        switch (ch)
        {
            case("A"):
            Console.WriteLine(num1+num2);
            break;

            case("B"):
            Console.WriteLine(num1-num2);
            break;

            case("C"):
            Console.WriteLine(num1*num2);
            break;

            case("D"):
            Console.WriteLine(num1/num2);
            break;

            default:
            Console.WriteLine("Enter a valid Choice");
            break;
        }


        
    }
}