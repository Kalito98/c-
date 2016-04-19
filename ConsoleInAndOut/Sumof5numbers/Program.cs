using System;

class Program
{
    static void Main()
    {
        int result = 0;
        int[] numArr = new int[5];
        for (int n = 0; n < 5; n++)
        {
            numArr[n] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < 5; i++)
        {
            result += numArr[i];
        }
        Console.WriteLine(result);
    }
}
