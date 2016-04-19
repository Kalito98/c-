using System;


class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int mask = 1 << 3;
        int nAndMask = n & mask;
        int bit = nAndMask >> 3;
        Console.WriteLine(bit);
    }
}
