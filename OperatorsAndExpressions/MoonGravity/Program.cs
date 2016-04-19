using System;


class Program
{
    static void Main()
    {
        double weight = double.Parse(Console.ReadLine());
        double weightMoon = weight * 17 / 100;
        Console.WriteLine("{0:F3}", weightMoon);
    }
}

