using System;

class Program
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        double radius = 2.0;
        double point = Math.Sqrt(((0.0 - x) * (0.0 - x)) + ((0.0 - y) * (0.0 - y)));
        if (radius <= point)
        {
            Console.Write("no ");
            Console.WriteLine("{0:F2}", point);
        }
        else
        {
            Console.Write("yes ");
            Console.WriteLine("{0:F2}", point);
        }

    }
}

