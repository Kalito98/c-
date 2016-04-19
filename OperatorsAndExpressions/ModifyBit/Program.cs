using System;

class Program
{
    static void Main()
    {
        long mask = 0;
        long result = 0;
        int n = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        int v = int.Parse(Console.ReadLine());
        if ((double)v == 0)
        {
            mask = ~((long)1 << p);
            result = mask & n;
            Console.WriteLine(result);
        }
        else
        {
            mask = ((long)1 << p);
            result = mask | n;
            Console.WriteLine(result);
        }
    }
}

