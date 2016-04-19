using System;

class Program
{
    static void Main()
    {
        float a = float.Parse(Console.ReadLine());
        float b = float.Parse(Console.ReadLine());
        float c = float.Parse(Console.ReadLine());
        float d = float.Parse(Console.ReadLine());
        float e = float.Parse(Console.ReadLine());
        float max0 = Math.Max(a, b);
        float max1 = Math.Max(c, d);
        float max2 = Math.Max(max0, max1);
        float maxAnswer = Math.Max(max2, e);
        Console.WriteLine(maxAnswer);
    }
}

