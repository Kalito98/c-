using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        BigInteger facN = 1;
        BigInteger facK = 1;

        for (int i = 1; i <= n; i++)
        {
            facN *= i;
        }

        for (int j = 1; j <= k; j++)
        {
            facK *= j;
        }
        BigInteger result = facN / facK;
        Console.WriteLine(result);
    }
}

