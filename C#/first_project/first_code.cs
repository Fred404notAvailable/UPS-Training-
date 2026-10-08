using System;

public class HelloWorld {
    public static void Main(string[] args) {
        Console.Write("Enter your 12th grade average: ");
        int average = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Your 12th grade average is: " + average);

        int limit = 90;
        int fee = 100000;

        if (average >= limit) {
            Console.WriteLine("Congratulations! You have passed.");
            Console.WriteLine("Your Scholarship fee is: " + (fee/2));
        } else {
            Console.WriteLine("Sorry, you have not passed.");
            Console.WriteLine("Your  fee is: " + fee);
        }
    }
}