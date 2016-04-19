using System;

class Program
{
    static void Main()
    {
        float a = float.Parse(Console.ReadLine());
        float b = float.Parse(Console.ReadLine());
        float c = float.Parse(Console.ReadLine());
        float answer = a * b * c;
        if (answer > 0)
        {
            Console.WriteLine("+");
        }
        else if (answer == 0)
        {
            Console.WriteLine("0");
        }
        else if (answer < 0)
        {
            Console.WriteLine("-");
        }
    }
}

