using System;

class Program
{
    static void Main()
    {
        int counter = 1;
        long curResult = 1;
        long result = 1;
        string text = "";
        while (true)
        {
            if (counter % 2 == 0)
            {
                text = Console.ReadLine();
                if (text == "END")
                {
                    break;
                }
                long number = int.Parse(text);

                for (int i = 0; i < text.Length; i++)
                {
                    long lastNumber = number % 10;
                    curResult = curResult * lastNumber;
                }
                result *= curResult;
                curResult = 1;
            }
            counter++;
        }
        Console.WriteLine(result);
    }
}

