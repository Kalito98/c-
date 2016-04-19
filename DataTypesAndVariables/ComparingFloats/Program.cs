using System;


    class Program
    {
        static void Main()
        {
        double first = double.Parse(Console.ReadLine());
        double second = double.Parse(Console.ReadLine());
        first = Math.Round(first, 6);
        second = Math.Round(second, 6);
        if (first == second)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }
    }
    }

