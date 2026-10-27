using System;

class Birds {
    string name;

    public Birds(string name) {
        this.name = name;
        Console.WriteLine("Birds Constructor");
        Console.WriteLine("Bird Name: " + name);
    }

    public void Make_sound() {
        Console.WriteLine(name+" Sound");
    }
}

class Parrot : Birds {
    public Parrot(string name) : base(name) {
        Console.WriteLine("Parrot Constructor");
    }

    public new void Make_sound() {
        base.Make_sound();
        Console.WriteLine("Parrot says: keech keech");
    }
}

class Sparrow : Birds {
    public Sparrow(string name) : base(name) {
        Console.WriteLine("Sparrow Constructor");
    }

    public new void Make_sound() {
        base.Make_sound();
        Console.WriteLine("Sparrow says: Chirp! Chirp!");
    }
}

public class Program {
    public static void Main(string[] args) {
        Parrot p = new Parrot("Parrot");
        p.Make_sound();
        Console.WriteLine();

        Sparrow s = new Sparrow("Sparrow");
        s.Make_sound();
    }
}
