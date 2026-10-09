using System;
public class VehicleRental
{
    public static void Main(string[] strings)
    {
        int vehicle_type;
        int days;
        int age;
        string licence;
        decimal daily_rate = 0;
        decimal total_rent = 0;
        decimal final_amount = 0;

        Console.WriteLine("Select vehicle type:");
        Console.WriteLine("1. Car\t₹ 1000 / day");
        Console.WriteLine("2. Bike\t₹ 300 / day");
        vehicle_type = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the number of rental days:");
        days = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter your age:");
        age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Do you have a valid driving licence? (yes/no):");
        licence = Console.ReadLine();

        if (age < 20 || age > 45)
        {
            Console.WriteLine("Error: Age must be between 20 and 45 to rent a vehicle.");
            return;
        }

        if (string.IsNullOrEmpty(licence) || licence.Trim().ToLower() != "yes")
        {
            Console.WriteLine("Error: Valid driving licence is required.");
            return;
        }

        switch (vehicle_type)
        {
            case 1:
                daily_rate = 1000;
                break;
            case 2:
                daily_rate = 300;
                break;
            default:
                Console.WriteLine("Error: Enter a valid vehicle type.");
                return;
        }

        total_rent = days * daily_rate;
        final_amount = total_rent;

        Console.WriteLine("Your Rental Duration is " + days + " days");
        Console.WriteLine("Your Total Rent is " + total_rent);
        Console.WriteLine("Your Final Rental Amount is " + final_amount);
    }
}