using System;
public class Ecommerce
{
    public static void Main(string[] strings)
    {
        int category;
        int quantity;
        string coupon;
        string payment;
        decimal price_per_item=0;
        decimal order_value=0;
        decimal discount=0;
        decimal shipping_charges=350;
        decimal final_amount=0;
        Console.WriteLine("Select product category:");
        Console.WriteLine("1. Watch\t₹ 5000\n2. Stationary\t₹ 3000\n3. Dress\t₹ 8000");
        category=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the quantity:");
        quantity=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the coupon code (wat001, sat002, dre003, or none):");
        coupon=Console.ReadLine();
        Console.WriteLine("Enter payment method (Gpay/PhonePe):");
        payment=Console.ReadLine();
        switch(category)
        {
            case 1:
            price_per_item=5000;
            break;
            case 2:
            price_per_item=3000;
            break;
            case 3:
            price_per_item=8000;
            break;
            default:
            Console.WriteLine("Enter a valid category");
            return;
        }
        order_value=quantity*price_per_item;
        if(quantity<5)
        {
            Console.WriteLine("Error: Minimum purchase requirement is 5 items.");
            return;
        }
        if((category==1 && coupon=="wat001") || (category==2 && coupon=="sat002") || (category==3 && coupon=="dre003"))
        {
            discount=order_value*15/100;
        }
        else
        {
            discount=0;
        }
        if(payment=="Gpay" || payment=="PhonePe")
        {
            final_amount=(order_value-discount)+shipping_charges;
        }
        else
        {
            Console.WriteLine("Error: Invalid payment method. Only Gpay and PhonePe are allowed.");
            return;
        }
        Console.WriteLine("Your Order Value is "+order_value);
        Console.WriteLine("Your Discount is "+discount);
        Console.WriteLine("Your Shipping Charges is "+shipping_charges);
        Console.WriteLine("Your Final Amount is "+final_amount);
    }
}