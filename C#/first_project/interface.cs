using System;

public interface IArthemtic1{
    int Add(int a, int b);
    int Sub(int a, int b);
}

public interface IArthemtic2{
    int mul(int a, int b);
    int div(int a, int b);
}

public class Calculation : IArthemtic1, IArthemtic2{
    public int Add(int a, int b){
        return a+b;
    }
    public int Sub(int a, int b){
        return a-b;
    }
    public int mul(int a, int b){
        return a*b;
    }
    public int div(int a, int b){
        return a/b;
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
