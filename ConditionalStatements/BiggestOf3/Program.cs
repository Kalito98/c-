using System;

class Program
{
    static void Main()
    {
        float a = float.Parse(Console.ReadLine());
        float b = float.Parse(Console.ReadLine());
        float c = float.Parse(Console.ReadLine());
        float max = Math.Max(a, b);
        float max1 = Math.Max(max, c);
        Console.WriteLine(max1);
    }
}

