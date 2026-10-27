using System;

public class Polymor{
    public int Add(int a, int b){
        return a+b;
    }
    public double Add(double n1,double n2){
        return n1+n2;
    }
    public string Add(string s1,string s2){
        return s1+" "+s2;
    }

}

public class demo{
    public static void Main(string[]args){
        Polymor obj = new Polymor();
        Console.WriteLine(obj.Add(1,2));
        Console.WriteLine(obj.Add(1.1,2.2));
        Console.WriteLine(obj.Add("hello","world"));
    }
}
