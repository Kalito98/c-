using System;

class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        number = (number / 100) % 10;
        if (number == 7)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false " + number);
        }
    }
}

