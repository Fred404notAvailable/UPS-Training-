using System;

public class Customer {

    private const double FIXED_CHARGE = 50.0;
    private const double SURCHARGE_RATE = 0.15;

    public string CustomerId;
    public string Name;
    public int Units;
    public double TotalBill;

    public void AcceptDetails() {
        Console.Write("Customer ID   : ");
        CustomerId = Console.ReadLine();

        Console.Write("Customer Name : ");
        Name = Console.ReadLine();

        Console.Write("Units Consumed: ");
        while (!int.TryParse(Console.ReadLine(), out Units) || Units < 0) {
            Console.Write("Invalid. Enter a valid unit count: ");
        }
    }

    private double CalcUnitCharges() {
        double charge = 0;

        if (Units <= 100) {
            charge = Units * 2.00;
        } else if (Units <= 200) {
            charge = (100 * 2.00) + ((Units - 100) * 3.50);
        } else if (Units <= 300) {
            charge = (100 * 2.00) + (100 * 3.50) + ((Units - 200) * 5.00);
        } else {
            charge = (100 * 2.00) + (100 * 3.50) + (100 * 5.00) + ((Units - 300) * 7.00);
        }

        return charge;
    }

    private string GetCategory(double bill) {
        if (bill <= 500)  return "Low";
        if (bill <= 1500) return "Medium";
        return "High";
    }

    public void CalculateAndDisplay() {
        double unitCharge  = CalcUnitCharges();
        double surcharge   = (Units > 300) ? unitCharge * SURCHARGE_RATE : 0;
        TotalBill          = unitCharge + FIXED_CHARGE + surcharge;
        string category    = GetCategory(TotalBill);

        Console.WriteLine("\nBill Summary");
        Console.WriteLine("Customer ID     : " + CustomerId);
        Console.WriteLine("Customer Name   : " + Name);
        Console.WriteLine("Units Consumed  : " + Units);
        Console.WriteLine("Unit Charges    : Rs. " + unitCharge.ToString("F2"));
        Console.WriteLine("Fixed Charge    : Rs. " + FIXED_CHARGE.ToString("F2"));
        Console.WriteLine("Surcharge (15%) : Rs. " + surcharge.ToString("F2") +
                          (Units <= 300 ? " (not applicable)" : ""));
        Console.WriteLine("Total Bill      : Rs. " + TotalBill.ToString("F2"));
        Console.WriteLine("Payment Category: " + category);
        
    }
}

public class ElectricityBill_Main {
    public static void Main(string[] args) {
        double totalRevenue   = 0;
        int    customerCount  = 0;
        string answer;

        Console.WriteLine("Electricity Bill Management System\n");

        do {
            customerCount++;
            Console.WriteLine("Customer " + customerCount + ":\n");

            Customer c = new Customer();
            c.AcceptDetails();
            c.CalculateAndDisplay();

            totalRevenue += c.TotalBill;

            Console.Write("Add another customer? (y/n): ");
            answer = Console.ReadLine();
            Console.WriteLine();

        } while (answer != null && answer.Trim().ToLower() == "y");

        Console.WriteLine("Final Report");
        Console.WriteLine("Customers Processed : " + customerCount);
        Console.WriteLine("Total Revenue       : Rs. " + totalRevenue.ToString("F2"));
        Console.WriteLine("Average Bill        : Rs. " + (totalRevenue / customerCount).ToString("F2"));
        
    }
}
