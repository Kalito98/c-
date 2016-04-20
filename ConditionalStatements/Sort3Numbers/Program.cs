using System;

class Program
{
    static void Main()
    {
        float a = float.Parse(Console.ReadLine());
        float b = float.Parse(Console.ReadLine());
        float c = float.Parse(Console.ReadLine());

        if (a > b && a > c)
        {
            Console.Write(a + " ");
            if (b > c)
            {
                Console.Write(b + " ");
                Console.Write(c + " ");
            }
            else
            {
                Console.Write(c + " ");
                Console.Write(b + " ");

            }
        }
        if (b > a && b > c)
        {
            Console.Write(b + " ");

            if (a > c)
            {
                Console.Write(a + " ");
                Console.Write(c + " ");

            }
            else
            {
                Console.Write(c + " ");
                Console.Write(a + " ");

            }

        }
        if (c > a && c > b)
        {
            Console.Write(c + " ");

            if (b > a)
            {
                Console.Write(b + " ");
                Console.Write(a + " ");
            }
            else
            {
                Console.Write(a + " ");
                Console.Write(b + " ");
            }

        }
        Console.WriteLine();
    }
}

