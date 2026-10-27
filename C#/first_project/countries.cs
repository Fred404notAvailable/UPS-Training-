using System;

class Country {
    public Country() {
        Console.WriteLine("Country Constructor");
    }

    public void Capital() {
        Console.WriteLine("Capital: Unknown");
    }

    public void Language() {
        Console.WriteLine("Language: Unknown");
    }
}

class India : Country {
    public India() : base() {
        Console.WriteLine("India Constructor");
    }

    public new void Capital() {
        base.Capital();
        Console.WriteLine("Capital: New Delhi");
    }

    public new void Language() {
        base.Language();
        Console.WriteLine("Language: Hindi");
    }
}

class USA : Country {
    public USA() : base() {
        Console.WriteLine("USA Constructor");
    }

    public new void Capital() {
        base.Capital();
        Console.WriteLine("Capital: Washington D.C.");
    }

    public new void Language() {
        base.Language();
        Console.WriteLine("Language: English");
    }
}

class UK : Country {
    public UK() : base() {
        Console.WriteLine("UK Constructor");
    }

    public new void Capital() {
        base.Capital();
        Console.WriteLine("Capital: London");
    }

    public new void Language() {
        base.Language();
        Console.WriteLine("Language: English");
    }
}

public class Program {
    public static void Main(string[] args) {
        India india = new India();
        india.Capital();
        india.Language();
        Console.WriteLine();

        USA usa = new USA();
        usa.Capital();
        usa.Language();
        Console.WriteLine();

        UK uk = new UK();
        uk.Capital();
        uk.Language();
    }
}
