using System;
namespace ConsoleApplication1
{
    class PrimeCheck
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            bool check = true;
            int count = 1;
            while (count <= Math.Sqrt(num))
            {
                if (num % count == 0 && count > 1)
                {
                    check = false;
                }
                count++;
            }
            if (num < 2)
            {
                check = false;
            }
            Console.WriteLine(check ? "true" : "false");
        }
    }
}