using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char space = ' ';
        char vertical = '|';
        char horizontal = '-';
        char sides = ':';
        int workSpace = n * 2 - 1;

        for (int col = 0; col < workSpace; col++)
        {
            Console.WriteLine(sides);
            for (int row = 0; row < workSpace; row++)
            {
                if (col == 0 && row >= n)
                {
                    Console.WriteLine(sides);
                }
            }
        }

    }
}

