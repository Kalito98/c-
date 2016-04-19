using System;



class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int number2 = number % 2;
        if (number2 != 0)
        {
            Console.WriteLine("odd " + number);
        }
        else
        {
            Console.WriteLine("even " + number);
        }
    }
}

