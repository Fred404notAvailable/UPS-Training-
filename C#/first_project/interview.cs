using System;

public class Inter
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter your Aptitude round marks");
        int apti = Convert.ToInt32(Console.ReadLine());
        if (apti > 70)
        {
            Console.WriteLine("You've Selected for next round ");
            Console.WriteLine("Enter your technical round Marks");
            int tech = Convert.ToInt32(Console.ReadLine());

            if (tech > 80)
            {
                Console.WriteLine("You've Selected for next round ");
                Console.WriteLine("Enter your HR round Marks");
                int hr = Convert.ToInt32(Console.ReadLine());

                if (hr > 80)
                {
                    Console.WriteLine("Congrats You are placed ");
                    int total = hr+tech+apti;
                    if (total > 280)
                    {
                        Console.WriteLine("Your Package is 25000");
                        
                    }
                    else if (total>250 && total <= 280)
                    {
                        Console.WriteLine("Your Package is 20000");
                    }
                    else
                    {
                        Console.WriteLine("Your Package is 15000");
                    }
                    

                }
                else
            {
                Console.WriteLine("Sorry you did't qualify for next round");
            }
                
            }
            else
            {
                Console.WriteLine("Sorry you did't qualify for next round");
            }
        }else
            {
                Console.WriteLine("Sorry you did't qualify for next round");
            }
    }
}