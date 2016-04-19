using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        int time5 = 0;
        int loop = 1;
        for (int i = 0; i < loop; i++)
        {
            if (n + 5 <= m)
            {
                loop += 1;
                time5 += 1;
                n += 5;
            }
        }
        Console.WriteLine(time5);
    }
}

