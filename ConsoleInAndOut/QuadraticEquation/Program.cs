﻿using System;


class Program
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double d = (b * b) - (4 * a * c);
        double answer1 = 0;
        double answer2 = 0;
        if (d > 0)
        {
            answer1 = ((b * -1) + Math.Sqrt(d)) / (2 * a);
            answer2 = ((b * -1) - Math.Sqrt(d)) / (2 * a);
            Console.WriteLine("{0:F2}", answer2);
            Console.WriteLine("{0:F2}", answer1);
        }
        else if (d == 0)
        {
            answer1 = -b / (2 * a);
            Console.WriteLine("{0:F2}", answer1);
        }
        else if (d < 0)
        {
            Console.WriteLine("no real roots");
        }

    }
}

