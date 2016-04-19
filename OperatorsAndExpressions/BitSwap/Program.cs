using System;

class Program
{
    static void Main()
    {
        long nAndMask = 0;
        long bit = 0;
        long mask = 0;
        int result = 0;
        int n = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        int q = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());


        for (int i = p; i < (p + k); i++)
        {
            mask = 1 << i;
            nAndMask = n & mask;
            bit = nAndMask >> i;
            Console.WriteLine(bit);

        }
    }
}


