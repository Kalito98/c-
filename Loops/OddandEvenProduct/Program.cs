using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string number = Console.ReadLine();
        number.Split();
        string[] numArr = number.Split(' ');
        int[] intNumArr = Array.ConvertAll(numArr, int.Parse);
        long resultEven = 1;
        long resultOdd = 1;
           
      
        for (int i = 0; i < n; i++)
        {
            if (i % 2 == 0)
            {
                resultEven *= intNumArr[i];
            }
            else
            {
                resultOdd *= intNumArr[i];
            }
        }
        if (resultEven == resultOdd)
        {
            Console.WriteLine("yes " + resultOdd);
        }
        else
        {
            Console.WriteLine("no " + resultEven + " " + resultOdd);
        }
    }
}

