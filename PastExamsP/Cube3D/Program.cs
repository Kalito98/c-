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
        int mid = n - 1;

        for (int row = 0; row < workSpace; row++)
        {
            for (int col = 0; col < workSpace; col++)
            {
                if (row == 0 && col < n ||
                    row == mid && col < n ||
                    col == 0 && row < n ||
                    col == mid && row < n ||
                    col >= mid && row == workSpace - 1 ||
                    col == workSpace - 1 && row >= mid ||
                    col - row == mid ||
                    col - row == 0 && col > mid ||
                    col - row == n - workSpace

                    )
                {
                    Console.Write(sides);
                }
                else if (
                    col > mid && col - row <= mid && col - row >= 0
                    )
                {
                    Console.Write(vertical);
                }
                else if (
                    row > mid && col - row >= n - workSpace
                    )
                {
                    Console.Write(horizontal);
                }
                else
                {
                    Console.Write(space);
                }
            }
            Console.WriteLine();
        }

    }
}

