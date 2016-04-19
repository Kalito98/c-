using System;

class Program
{
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());
        long last = 0;
        long current = 1;
        long answer = 0;
        if (n == 1)
        {
            Console.WriteLine("0");
        }
        
            for (long i = 1; i < n; i++)
            {
            Console.Write(answer);
            if (i < (n - 1))
            {
                Console.Write(", ");
            }
                answer = current + last;
                last = current;
                current = answer;
            if (answer == 1)
            {
                Console.Write("1, ");
            }
            
        }
       
    }
}

