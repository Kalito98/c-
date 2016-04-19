using System;

class Program
{
    static void Main()
    {
        float first = float.Parse(Console.ReadLine());
        float second = float.Parse(Console.ReadLine());
        float shit = 0;
        if (first > second)
        {
            shit = first;
            first = second;
            second = shit;
            Console.Write("{0} {1}", first, second);
        }
        else
        {
            Console.Write("{0} {1}", first, second);
        }

    }
}

