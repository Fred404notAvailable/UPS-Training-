using System;
public class Rooms
{
    public static void Main(string[] strings)
    {
        int food_days;
        int room_days;
        int food_amt=0;
        int Toal_amt=0;
        int room_type;
        int gst_amt=0;
        string member;
        int member_discount=0;
        Console.WriteLine("Enter the number of days you want to stay");
        room_days=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the number of days you want to take food");
        food_days=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the type of room you want to stay in");
        Console.WriteLine("1. Normal Room\t₹ 2000\n2. Double Room\t₹ 3500\n3. Suite\t₹ 5000");
        room_type=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Are you a member of our hotel? (yes/no)");
        member=Console.ReadLine();
        switch(room_type)
        {
            case 1:
            Toal_amt=room_days*2000;
            break;
            case 2:
            Toal_amt=room_days*3500;
            break;
            case 3:
            Toal_amt=room_days*5000;
            break;
            default:
            Console.WriteLine("Enter a valid room type");
            break;
        }
        gst_amt=Toal_amt*12/100;
        if(member=="yes")
        {
            member_discount=Toal_amt*10/100;
        }
        else 
        {
            member_discount=0;
        }
        if(food_days>0)
        {
            food_amt=food_days*500;
        }
        else
        {
            food_amt=0;
        }
        Console.WriteLine("Your Room Amount is "+Toal_amt);
        Console.WriteLine("Your GST Amount is "+gst_amt);
        Console.WriteLine("Your Member Discount is "+member_discount);
        Console.WriteLine("Your Food Amount is "+food_amt);
        Console.WriteLine("Your Total Amount is "+((Toal_amt+gst_amt+food_amt)-(member_discount)));
    }
}