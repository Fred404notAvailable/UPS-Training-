using System;

public class Armstrong{
    public bool isarmstron(int num){
        if(num<0) return false;
        int sum = 0;
        int temp = num;
        while(temp>0){
            int digit = temp%10;
            sum += digit*digit*digit;
            temp /= 10;
        }
        return sum == num;
    }
}
public class prg{
    public static void Main(string[]args){
        Console.Write("Enter the number: ");
        int num = int.Parse(Console.ReadLine());
        
        Armstrong armstrong = new Armstrong();
        if(armstrong.isarmstron(num)){
            Console.WriteLine("Number is Armstrong");
        }else{
            Console.WriteLine("Number is not Armstrong");
        }
    }
}