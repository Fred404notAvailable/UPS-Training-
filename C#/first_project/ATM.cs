using System;
public class Atm
{
    public static void Main(string[] args)
    {
        int balance = 100000;
        Console.WriteLine("Enter your Atm Pin");
        int pin = Convert.ToInt32(Console.ReadLine());
        if (pin == 2005)
        {
            Console.WriteLine("Enter your Choice");
            Console.WriteLine("A. Check Balance\nB. Withdraw Money\nC. Deposit Money");
            String cha = Console.ReadLine();
            switch(cha)
            {
                case("A"):
                Console.WriteLine("Your Balance is " + balance);
                break;
                case("B"):
                        Console.WriteLine("Enter the amount to withdraw");
                        int withdraw = Convert.ToInt32(Console.ReadLine());
                        if (withdraw <= balance)
                        {
                            Console.WriteLine("You have withdrawn " + withdraw);
                            balance = balance - withdraw;
                            Console.WriteLine("Your Balance is " + balance);
                        }
                        else
                        {
                            Console.WriteLine("Insufficient Balance");
                        }
                break;
                case("C"):
                Console.WriteLine("Enter the amount to deposit");
                int deposit = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the choise for the mode of deposit");
                Console.WriteLine("A. Cash\nB. UPI");
                string mode = Console.ReadLine();

                if (mode == "A")
                {
                    Console.WriteLine("You have deposited " + deposit + " in cash");
                }
                else if (mode == "B")
                {
                    Console.WriteLine("You have deposited " + deposit + " through UPI");
                }
                else
                {
                    Console.WriteLine("Invalid mode of deposit");
                }
                balance = balance + deposit;
                Console.WriteLine("Your Balance is " + balance);
                break;
                default:
                Console.WriteLine("Enter a valid Choice");
                break;
            }
        }
        else
        {
            Console.WriteLine("Invalid Pin");
        }
    }
}