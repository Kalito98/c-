using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        string input = "123456789"; // Console.ReadLine();
        BigInteger product = 1;
        while (input.Length > 0)
        {
            input = input.Substring(0, input.Length - 1);
            int sum = 0;
            for (int i = 0; i < input.Length; i += 2)
            {
                sum += input[i] - '0';
            }
            product *= sum;
        }
    }
}

