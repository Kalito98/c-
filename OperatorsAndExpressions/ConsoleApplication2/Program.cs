using System;


class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int numberby5 = number % 5;
        int numberby7 = number % 7;
        if (numberby5 + numberby7 == 0)
        {
            Console.WriteLine("true " + number);
        }
        else
        {
            Console.WriteLine("false " + number);
        }
    }
}

