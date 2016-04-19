using System;


class Program
{
    static void Main()
    {
        double p = Math.PI;
        double r = double.Parse(Console.ReadLine());
        double perimeter = 2 * p * r;
        double area = p * (r * r);
        Console.Write("{0:F2}", perimeter);
        Console.Write(" ");
        Console.WriteLine("{0:F2}", area);
    }
}

