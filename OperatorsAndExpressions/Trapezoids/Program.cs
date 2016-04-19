using System;



class Program
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double h = double.Parse(Console.ReadLine());
        double area = ((a + b) * h) / 2.0;
        Console.WriteLine("{0:F7}", area);
    }
}

