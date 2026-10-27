using System;

public abstract class Arthemtic{
    public abstract int Add(int a, int b);
    public abstract int Sub(int a, int b);

    public int mul(int a,int b){
        return a*b;
    }
    public int div(int a,int b){
        return a/b;
    }
}

class Calculation : Arthemtic{
    public override int Add(int a,int b){
        return a+b;
    }
    public override int Sub(int a,int b){
        return a-b;
    }
}
public class Program{
    public static void Main(string[] args){
        Calculation c = new Calculation();
        Console.WriteLine("Addition: "+c.Add(1,2));
        Console.WriteLine("Substraction: "+c.Sub(1,2));
        Console.WriteLine("Multiplication: "+c.mul(1,2));
        Console.WriteLine("Division: "+c.div(1,2));
    }
}

