using System;



class Program
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        Console.WriteLine(a);
        Console.WriteLine(b);
        int a1 = a;
        a = b;
        b = a1;
        Console.WriteLine(a);
        Console.WriteLine(b);
    }
}

