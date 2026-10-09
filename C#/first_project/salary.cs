using System;

public class Salary {
    public static void Main(string[] args) {
        Console.Write("Enter the Salary ");
        int sal = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter the Experience ");
        int experience = Convert.ToInt32(Console.ReadLine());
        
        double num_of_days = 26;
        double work_days = sal / num_of_days;
        
        Console.Write("Enter the No of days present: ");
        int num_of_days_present = Convert.ToInt32(Console.ReadLine());
        
        double present_sal = num_of_days_present * work_days;
        double bonus_amt = 0;
        
        if (experience > 5) {
            bonus_amt = sal * 0.10;
        }
        else if (experience > 3 && experience <= 5) {
            bonus_amt = sal * 0.05;
        }
        else if (experience > 1 && experience <= 3) {
            bonus_amt = sal * 0.01;
        }
        else {
            bonus_amt = 0;
        }
        
        double bonus_sal = present_sal + bonus_amt;

        Console.WriteLine("Total Salary: " + sal);
        Console.WriteLine("Total no of working days : " + num_of_days);
        Console.WriteLine("No of days Present : " + num_of_days_present);
        Console.WriteLine("Total salary based on no of days present : " + present_sal);
        Console.WriteLine("Total salary with bonus : " + bonus_sal);
    }
}