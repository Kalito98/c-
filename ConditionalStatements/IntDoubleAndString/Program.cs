using System;

class Program
{
    static void Main()
    {
        string type = Console.ReadLine();

        if (type == "integer")
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(number + 1);
        }
        else if (type == "real")
        {
            double number2 = double.Parse(Console.ReadLine());
            number2 += 1;
            Console.WriteLine("{0:F2}", number2);

        }
        else if (type == "text")
        {
            string number3 = Console.ReadLine();
            Console.WriteLine(number3 + "*");
        }
    }
}

