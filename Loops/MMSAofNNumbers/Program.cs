using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double min = 10000000000;
        double max = 0;
        double avg = 0;
        double sum = 0;
        for (int i = 0; i < n; i++)
        {
            int currN = int.Parse(Console.ReadLine());
            min = Math.Min(currN, min);
            max = Math.Max(currN, max);
            sum += currN;
            avg += currN;
        }
        avg = avg / n;
        Console.Write("min=");
        Console.WriteLine("{0:F2}", min);
        Console.Write("max=");
        Console.WriteLine("{0:F2}", max);
        Console.Write("sum=");
        Console.WriteLine("{0:F2}", sum);
        Console.Write("avg=");
        Console.WriteLine("{0:F2}", avg);

    }
}

//using System;
//
//    class MMSAofNNumbers
//{
//    static void Main()
//    {
//        int n = int.Parse(Console.ReadLine());
//        double number1 = double.Parse(Console.ReadLine());
//        double min = number1;
//        double max = number1;
//        double sum = number1;
//        double avg = number1;
//        for (int i = 2; i <= n; i++)
//        {
//            double number = double.Parse(Console.ReadLine());
//            min = Math.Min(min, number);
//            max = Math.Max(max, number);
//            sum = sum + number;
//            avg = sum / i;
//        }
//        Console.WriteLine("min={0:F2}", min);
//        Console.WriteLine("max={0:F2}", max);
//        Console.WriteLine("sum={0:F2}", sum);
//        Console.WriteLine("avg={0:F2}", avg);
//    }
//}
//
