using System;



class Program
{
    static void Main()
    {
        int abcd = int.Parse(Console.ReadLine());
        int d = abcd % 10;
        int c = (abcd / 10) % 10;
        int b = (abcd / 100) % 10;
        int a = (abcd / 1000) % 10;
        string d1 = d.ToString();
        string c1 = c.ToString();
        string b1 = b.ToString();
        string a1 = a.ToString();
        Console.WriteLine(a + b + c + d);
        Console.WriteLine(d1 + c1 + b1 + a1);
        Console.WriteLine(d1 + a1 + b1 + c1);
        Console.WriteLine(a1 + c1 + b1 + d1);
          
    }
}

