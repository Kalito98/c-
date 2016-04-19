using System;


class Program
{
    static void Main()
    {
        int p = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());

        long mask = 1 << n;
        long nAndMask = p & mask;
        long bit = nAndMask >> n;
        Console.WriteLine(bit);
    }
}
