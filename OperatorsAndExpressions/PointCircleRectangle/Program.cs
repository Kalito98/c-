using System;

class Program
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        double radius = 1.5;
        double point = Math.Sqrt(((1.0 - x) * (1.0 - x)) + ((1.0 - y) * (1.0 - y)));
        if (radius <= point)
        {
            Console.Write("outside circle ");
        }
        else
        {
            Console.Write("inside circle ");
        }

        if ((-1 <= x && x <= 5) && (-1 <= y && y <= 1))
        {
            Console.WriteLine("inside rectangle");
        }
        else
        {
            Console.WriteLine("outside rectangle");
        }

    }
}