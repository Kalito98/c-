using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double x = double.Parse(Console.ReadLine());
        double fact = 1;
        double afterFact = 0;
        double result = 1;

        for (int i = 1; i <= n; i++)
        {
            fact *= i;
            afterFact = fact;
            afterFact = afterFact / Math.Pow((double)x, i);
            result += afterFact;
        }
        Console.WriteLine("{0:F5}", result);
    }
}

