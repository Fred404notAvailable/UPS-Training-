using System;

public class Login
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the username");
        string username = Console.ReadLine();
        Console.Write("Enter the Password");
        string password = Console.ReadLine();
        string un = "Fred";
        string pass = "Fred@2005";
        if ((username == un) && (password == pass))
        {
           Console.WriteLine("Login success");
        }
        else
        {
            Console.WriteLine("Wrong Credentialsq");
            
        }
    }
}