using System;

public class DeliveryService
{
    public int CalculateDeliveryCharge(double distance){
        if(distance<=5){
            return 50;
        }else if(distance<=10){
            return 100;
        }else if(distance<=20){
            return 200;
        }else{
            return 300;
        }
    }
    public int CalculateDeliveryCharge(double distance, int weight){
        if(distance>5 && weight>5){
            return CalculateDeliveryCharge(distance) + (weight - 5) * 10;
        }
        else if (distance>10 && weight>10){
            return CalculateDeliveryCharge(distance) + (weight - 10) * 20;
        }
        else if (distance>20 && weight>20){
            return CalculateDeliveryCharge(distance) + (weight - 20) * 30;
        }
        else {
            return CalculateDeliveryCharge(distance);
        }
    }

    public int CalculateDeliveryCharge(double distance, int weight,bool express_delivery){
        if(express_delivery){
            return CalculateDeliveryCharge(distance,weight) + 100;
        }else{
            return CalculateDeliveryCharge(distance,weight);
        }
    }
    
    public static void Main(string[] args){
        DeliveryService ds = new DeliveryService();
        Console.WriteLine("Enter distance: ");
        double distance = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter weight: ");
        int weight = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter express delivery (true/false): ");
        bool express_delivery = bool.Parse(Console.ReadLine());
        Console.WriteLine("Delivery Charge: " + ds.CalculateDeliveryCharge(distance, weight, express_delivery));
    }
}