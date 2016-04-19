using System;

class Program
{
    static void Main()
    {
        Int64 number = Int64.Parse(Console.ReadLine());
        if (1 <= number && number <= 3)
        {
            number *= 10;
            Console.WriteLine(number);
        }
        else if (4 <= number && number <= 6)
        {
            number *= 100;
            Console.WriteLine(number);
        }
        else if (7 <= number && number <= 9)
        {
            number *= 1000;
            Console.WriteLine(number);
        }
        else if (0 <= number && number <= 10)
        {

            Console.WriteLine("invalid score");
        }

    }
}
