using System;
public class HospitalBilling
{
    public static void Main(string[] strings)
    {
        int ward_type;
        int days_stayed;
        string senior;
        decimal room_rate=0;
        decimal consultation_fee=800;
        decimal room_charges=0;
        decimal sub_total=0;
        decimal senior_discount=0;
        decimal final_amount=0;
        Console.WriteLine("Select ward type:");
        Console.WriteLine("1. General Ward\t₹ 500\n2. Private Room\t₹ 2000\n3. ICU\t\t₹ 5000");
        ward_type=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the number of days stayed");
        days_stayed=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Is the patient a senior citizen? (yes/no)");
        senior=Console.ReadLine();
        switch(ward_type)
        {
            case 1:
            room_rate=500;
            break;
            case 2:
            room_rate=2000;
            break;
            case 3:
            room_rate=5000;
            break;
            default:
            Console.WriteLine("Enter a valid ward type");
            break;
        }
        room_charges=days_stayed*room_rate;
        sub_total=room_charges+consultation_fee;
        if(senior=="yes")
        {
            senior_discount=sub_total*5/100;
        }
        else 
        {
            senior_discount=0;
        }
        final_amount=sub_total-senior_discount;
        Console.WriteLine("Your Room Charges is "+room_charges);
        Console.WriteLine("Your Consultation Fee is "+consultation_fee);
        Console.WriteLine("Your Subtotal is "+sub_total);
        Console.WriteLine("Your Senior Citizen Discount is "+senior_discount);
        Console.WriteLine("Your Final Amount is "+final_amount);
    }
}