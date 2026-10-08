using System;

public class bill()
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the Prodeuct Name: ");
        String prod_name = Console.ReadLine();

        Console.Write("Enter the Prodeuct Quantity: ");
        int prod_Quan =Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the Prodeuct Price: ");
        int prod_Price = Convert.ToInt32(Console.ReadLine());
        int total = (prod_Quan*prod_Price);
         Console.WriteLine("Prodeuct Name: "+prod_name);
        Console.WriteLine("Prodeuct Quantity: "+prod_Quan);
        Console.WriteLine("Prodeuct Price: "+prod_Price);
        Console.WriteLine("Total Price without GST: "+ total);
        double discount = 0;
        if (total > 5000) {
            discount = total * 0.3;
        }
        double gst = discount * 0.18;
        if (discount > 0) {
            Console.WriteLine("Discount: "+ discount);
            double total_with_gst  = total - discount + gst;    
            Console.WriteLine("18% GST: "+ gst);
            Console.WriteLine("Total Price with Discount and  GST: "+ total_with_gst);
        } else {
            Console.WriteLine("No Discount Applied");
              double total_with_gst  = total + gst;
            Console.WriteLine("18% GST: "+ gst);
         Console.WriteLine("Total Price with GST: "+ total_with_gst);
        }
      
    }
}