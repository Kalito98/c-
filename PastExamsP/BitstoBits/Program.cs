using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int maxZero = 0;
        int curZero = 0;
        int maxOne = 0;
        int curOne = 0;
        int currNumber = 0;

        for (int i = 0; i < n; i++)
        {
            currNumber = int.Parse(Console.ReadLine());
            for (int j = 29; j >= 0; j--)
            {
                int currBit = ((1 << j) & currNumber) >> j;

                if (currBit == 0)
                {
                    curZero += 1;
                    if (curZero > maxZero)
                    {
                        maxZero = curZero;
                    }
                    curOne = 0;
                }
                else
                {
                    curOne += 1;
                    if (curOne > maxOne)
                    {
                        maxOne = curOne;
                    }
                    curZero = 0;
                }
            }
        }
        Console.WriteLine(maxZero);
        Console.WriteLine(maxOne);
    }
}
